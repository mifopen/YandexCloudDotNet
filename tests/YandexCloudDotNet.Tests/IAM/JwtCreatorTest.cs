using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using YandexCloudDotNet.IAM;

namespace YandexCloudDotNet.Tests.IAM
{
    public class JwtCreatorTest
    {
        [Fact]
        public void Simple()
        {
            var jwtCreator = new JwtCreator();
            const string serviceAccountId = "ajeenb1baoqrtmhp5u7t";
            const string authorizationKeyId = "ajekelg1vqrfelqamrsc";
            var privateKey = new X509Certificate2(Path.GetFullPath("privatekey"));
            var expirationTime = TimeSpan.FromMinutes(15);
            var jwtToken = jwtCreator.Create(serviceAccountId, authorizationKeyId, privateKey, expirationTime);
            Console.Out.WriteLine(jwtToken);
        }
    }
}
