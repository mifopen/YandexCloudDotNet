using System.IO;
using System.Linq;
using System.Text;
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
            var secrets = new SecretsProvider().Get();
            var iamTokenClient = new IamTokenClient();
            var privateKeyStream = new MemoryStream(Encoding.UTF8.GetBytes(secrets.AuthorizationKeyPrivateKey));
            var iamToken = await iamTokenClient.Get(
                               secrets.ServiceAccountId,
                               secrets.AuthorizationKeyId,
                               privateKeyStream
                           );

            var client = new VisionClient();
            var image = File.OpenRead("Vision/image.png");
            var result = await client.RecognizeText(
                             secrets.FolderId,
                             iamToken,
                             image,
                             new[]
                             {
                                 "ru", "en"
                             }
                         );
            var words = result.Single()
                              .Results.Single()
                              .TextDetection
                              .Pages.Single()
                              .Blocks.Single()
                              .Lines.Single()
                              .Words;
            words.Select(x => x.Text)
                 .ShouldBe(
                     new[]
                     {
                         "Какой-то", "текст"
                     }
                 );
            output.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
        }
    }
}
