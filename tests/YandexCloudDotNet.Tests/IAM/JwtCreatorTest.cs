using System;
using System.IO;
using Xunit;
using Xunit.Abstractions;
using YandexCloudDotNet.IAM;

namespace YandexCloudDotNet.Tests.IAM
{
    public class JwtCreatorTest
    {
        private readonly ITestOutputHelper output;

        public JwtCreatorTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void Simple()
        {
            var userSecretsProvider = new UserSecretsProvider();
            var serviceAccountId = userSecretsProvider.Get("ServiceAccountId");
            var authorizationKeyId = userSecretsProvider.Get("AuthorizationKeyId");
            var jwtCreator = new JwtCreator();
            var expirationTime = TimeSpan.FromMinutes(15);
            var jwtToken = jwtCreator.Create(serviceAccountId,
                                             authorizationKeyId,
                                             File.OpenRead("private.key"),
                                             expirationTime);
            output.WriteLine(jwtToken);
        }
    }
}
