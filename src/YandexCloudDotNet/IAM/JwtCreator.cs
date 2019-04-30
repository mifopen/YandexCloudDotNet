using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Jose;

namespace YandexCloudDotNet.IAM
{
    public class JwtCreator
    {
        public string Create(string serviceAccountId,
                             string authorizationKeyId,
                             X509Certificate2 privateKey,
                             TimeSpan expirationTime)
        {
            if (expirationTime > TimeSpan.FromHours(1))
            {
                throw new Exception("Expiration time can't be more than 1 hour");
            }

            var payload = new Dictionary<string, object>
                          {
                              { "iss", serviceAccountId },
                              { "aud", "https://iam.api.cloud.yandex.net/iam/v1/tokens" },
                              { "iat", new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds() },
                              { "exp", new DateTimeOffset(DateTime.Now.Add(expirationTime)).ToUnixTimeSeconds() }
                          };
            var rsaPrivateKey = privateKey.GetRSAPrivateKey();
            var extraHeaders = new Dictionary<string, object> { { "kid", authorizationKeyId } };
            return JWT.Encode(payload, rsaPrivateKey, JwsAlgorithm.PS256, extraHeaders);
        }
    }
}
