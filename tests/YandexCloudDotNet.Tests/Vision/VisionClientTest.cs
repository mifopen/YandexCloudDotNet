using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Shouldly;
using Xunit;
using Xunit.Abstractions;
using YandexCloudDotNet.IAM;
using YandexCloudDotNet.Vision;

namespace YandexCloudDotNet.Tests.Vision
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
            var image = File.OpenRead("Vision/image.png");
            var result = await client.RecognizeText(folderId,
                                                    iamToken,
                                                    image,
                                                    new[]
                                                    {
                                                        "ru", "en"
                                                    });
            var words = result.Single()
                              .Results.Single()
                              .TextDetection
                              .Pages.Single()
                              .Blocks.Single()
                              .Lines.Single()
                              .Words;
            words.Select(x => x.Text)
                 .ShouldBe(new[]
                           {
                               "Какой-то", "текст"
                           });
            output.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
        }
    }
}
