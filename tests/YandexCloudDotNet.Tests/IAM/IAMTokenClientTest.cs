using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using YandexCloudDotNet.IAM;

namespace YandexCloudDotNet.Tests.IAM
{
    public class IAMTokenClientTest
    {
        private readonly ITestOutputHelper output;

        public IAMTokenClientTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public async void Simple()
        {
            var secrets = new SecretsProvider().Get();
            var client = new IamTokenClient();
            var privateKeyStream = new MemoryStream(Encoding.UTF8.GetBytes(secrets.AuthorizationKeyPrivateKey));
            var iamToken = await client.Get(
                               secrets.ServiceAccountId,
                               secrets.AuthorizationKeyId,
                               privateKeyStream
                           );
            output.WriteLine(iamToken);
        }
    }
}
