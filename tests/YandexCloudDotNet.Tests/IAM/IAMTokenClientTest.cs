using System.IO;
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
            var userSecretsProvider = new UserSecretsProvider();
            var client = new IamTokenClient();
            var serviceAccountId = userSecretsProvider.Get("ServiceAccountId");
            var authorizationKeyId = userSecretsProvider.Get("AuthorizationKeyId");
            var iamToken = await client.Get(serviceAccountId,
                                                    authorizationKeyId,
                                                    File.OpenRead("private.key"));
            output.WriteLine(iamToken);
        }
    }
}
