using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Jose;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;

namespace YandexCloudDotNet.IAM
{
    public class JwtCreator
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
                              {"iss", serviceAccountId},
                              {"aud", "https://iam.api.cloud.yandex.net/iam/v1/tokens"},
                              {"iat", new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds()},
                              {"exp", new DateTimeOffset(DateTime.Now.Add(expirationTime)).ToUnixTimeSeconds()}
                          };
            var rsaPrivateKey = ReadPrivateKey(privateKey);
            var extraHeaders = new Dictionary<string, object> {{"kid", authorizationKeyId}};
            return JWT.Encode(payload, rsaPrivateKey, JwsAlgorithm.PS256, extraHeaders);
        }

        private static RSA ReadPrivateKey(Stream privateKey)
        {
            RsaPrivateCrtKeyParameters rsaPrivateCrtKeyParameters;
            using (var reader = new StreamReader(privateKey))
                rsaPrivateCrtKeyParameters = (RsaPrivateCrtKeyParameters)new PemReader(reader).ReadObject();
            var rp = DotNetUtilities.ToRSAParameters(rsaPrivateCrtKeyParameters);
            var rsa = RSA.Create();
            rsa.ImportParameters(rp);
            return rsa;
        }
    }
}
