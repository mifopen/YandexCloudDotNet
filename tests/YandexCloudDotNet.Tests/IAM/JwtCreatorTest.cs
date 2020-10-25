using System;
using System.IO;
using System.Text;
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
            var secrets = new SecretsProvider().Get();
            var jwtCreator = new JwtCreator();
            var expirationTime = TimeSpan.FromMinutes(15);
            var privateKeyStream = new MemoryStream(Encoding.UTF8.GetBytes(secrets.AuthorizationKeyPrivateKey));
            var jwtToken = jwtCreator.Create(
                secrets.ServiceAccountId,
                secrets.AuthorizationKeyId,
                privateKeyStream,
                expirationTime
            );
            output.WriteLine(jwtToken);
        }
    }
}
