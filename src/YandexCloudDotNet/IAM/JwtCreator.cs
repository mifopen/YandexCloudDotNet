using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Jose;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;

namespace YandexCloudDotNet.IAM
{
    internal class JwtCreator
    {
        public string Create(string serviceAccountId,
                             string authorizationKeyId,
                             Stream privateKey,
                             TimeSpan expirationTime)
        {
            if (expirationTime > TimeSpan.FromHours(1))
            {
                throw new Exception("Expiration time can't be more than 1 hour");
            }

            var payload = new Dictionary<string, object>
                          {
                              {
                                  "iss", serviceAccountId
                              },
                              {
                                  "aud", "https://iam.api.cloud.yandex.net/iam/v1/tokens"
                              },
                              {
                                  "iat", new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()
                              },
                              {
                                  "exp", new DateTimeOffset(DateTime.Now.Add(expirationTime)).ToUnixTimeSeconds()
                              }
                          };
            var rsaPrivateKey = ReadPrivateKey(privateKey);
            var extraHeaders = new Dictionary<string, object>
                               {
                                   {
                                       "kid", authorizationKeyId
                                   }
                               };
            return JWT.Encode(payload, rsaPrivateKey, JwsAlgorithm.PS256, extraHeaders);
        }

        private static RSA ReadPrivateKey(Stream privateKey)
        {
            RsaPrivateCrtKeyParameters privateKeyParams;
            using (var reader = new StreamReader(privateKey))
            {
                privateKeyParams = (RsaPrivateCrtKeyParameters)new PemReader(reader).ReadObject();
            }

            var rp = new RSAParameters
                     {
                         Modulus = privateKeyParams.Modulus.ToByteArrayUnsigned(),
                         P = privateKeyParams.P.ToByteArrayUnsigned(),
                         Q = privateKeyParams.Q.ToByteArrayUnsigned(),
                         DP = privateKeyParams.DP.ToByteArrayUnsigned(),
                         DQ = privateKeyParams.DQ.ToByteArrayUnsigned(),
                         InverseQ = privateKeyParams.QInv.ToByteArrayUnsigned(),
                         D = privateKeyParams.Exponent.ToByteArrayUnsigned(),
                         Exponent = privateKeyParams.PublicExponent.ToByteArrayUnsigned()
                     };
            var rsa = RSA.Create();
            rsa.ImportParameters(rp);
            return rsa;
        }
    }
}
