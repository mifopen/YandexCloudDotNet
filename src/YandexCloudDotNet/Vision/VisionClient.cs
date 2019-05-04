using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using YandexCloudDotNet.Vision.DTO;

namespace YandexCloudDotNet.Vision
{
    public class VisionClient
    {
        public async Task<Response> RecognizeText(string folderId, string iamToken, Stream image, string[] languages)
        {
            var client = new HttpClient();
            var content = Convert.ToBase64String(ReadFully(image));
            var request = new Request
                          {
                              FolderId = folderId,
                              AnalyzeSpecs = new[]
                                             {
                                                 new AnalyzeSpec
                                                 {
                                                     Content = content,
                                                     Features = new Feature[]
                                                                {
                                                                    new TextDetectionFeature
                                                                    {
                                                                        TextDetectionConfig =
                                                                            new TextDetectionConfig
                                                                            {
                                                                                LanguageCodes = languages
                                                                            }
                                                                    },
                                                                }
                                                 }
                                             }
                          };
            const string url = "https://vision.api.cloud.yandex.net/vision/v1/batchAnalyze";
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", iamToken);
            var response = await client.PostAsync(url,
                                                  new StringContent(JsonConvert.SerializeObject(request,
                                                                                                Formatting.None,
                                                                                                new
                                                                                                JsonSerializerSettings
                                                                                                {
                                                                                                    ContractResolver =
                                                                                                        new
                                                                                                            CamelCasePropertyNamesContractResolver()
                                                                                                })));
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ToString());
            }

            var responseAsString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<Response>(responseAsString,
                                                                 new JsonSerializerSettings
                                                                 {
                                                                     ContractResolver =
                                                                         new CamelCasePropertyNamesContractResolver()
                                                                 });
            return result;
        }

        private static byte[] ReadFully(Stream input)
        {
            using (var ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
