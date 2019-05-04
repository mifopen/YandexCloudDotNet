using System.IO;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;
using YandexCloudDotNet.IAM;
using YandexCloudDotNet.Vision;

namespace YandexCloudDotNet.Tests.IAM
{
    public class VisionClientTest
    {
        private readonly ITestOutputHelper output;

        public VisionClientTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public async void Simple()
        {
            var userSecretsProvider = new UserSecretsProvider();
            var iamTokenClient = new IAMTokenClient();
            var serviceAccountId = userSecretsProvider.Get("ServiceAccountId");
            var authorizationKeyId = userSecretsProvider.Get("AuthorizationKeyId");
            var iamToken = await iamTokenClient.GetIAMToken(serviceAccountId,
                                                            authorizationKeyId,
                                                            File.OpenRead("private.key"));

            var client = new VisionClient();
            var folderId = userSecretsProvider.Get("FolderId");
            var image = File.OpenRead("jpg.jpg");
            var result = await client.RecognizeText(folderId,
                                                    iamToken,
                                                    image,
                                                    new[] {"ru", "en"});
            output.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
        }
    }
}
