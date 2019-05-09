using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf;
using Grpc.Core;
using Yandex.Cloud.Ai.Vision.V1;
using YandexCloudDotNet.Vision.DTO;
using AnalyzeResult = YandexCloudDotNet.Vision.DTO.AnalyzeResult;
using Block = YandexCloudDotNet.Vision.DTO.Block;
using FeatureResult = YandexCloudDotNet.Vision.DTO.FeatureResult;
using Line = YandexCloudDotNet.Vision.DTO.Line;
using Page = YandexCloudDotNet.Vision.DTO.Page;
using Polygon = YandexCloudDotNet.Vision.DTO.Polygon;
using Status = Google.Rpc.Status;
using Vertex = YandexCloudDotNet.Vision.DTO.Vertex;
using Word = YandexCloudDotNet.Vision.DTO.Word;

namespace YandexCloudDotNet.Vision
{
    public class VisionClient
    {
        public async Task<AnalyzeResult[]> RecognizeText(string folderId,
                                                         string iamToken,
                                                         Stream image,
                                                         string[] languages)
        {
            var channel = new Channel("vision.api.cloud.yandex.net", 443, new SslCredentials());
            var client = new VisionService.VisionServiceClient(channel);
            var request = new BatchAnalyzeRequest
                          {
                              FolderId = folderId,
                              AnalyzeSpecs =
                              {
                                  new AnalyzeSpec
                                  {
                                      Content = ByteString.FromStream(image),
                                      Features =
                                      {
                                          new Feature
                                          {
                                              Type = Feature.Types.Type.TextDetection,
                                              TextDetectionConfig = new FeatureTextDetectionConfig
                                                                    {
                                                                        LanguageCodes =
                                                                        {
                                                                            languages
                                                                        }
                                                                    }
                                          }
                                      }
                                  }
                              }
                          };
            var headers = new Metadata
                          {
                              {
                                  "Authorization", "Bearer " + iamToken
                              }
                          };
            var response = await client.BatchAnalyzeAsync(request, headers).ResponseAsync;
            return response.Results
                           .Select(ConvertAnalyzeResult)
                           .ToArray();
        }

        private static AnalyzeResult ConvertAnalyzeResult(Yandex.Cloud.Ai.Vision.V1.AnalyzeResult analyzeResult)
        {
            return new AnalyzeResult(analyzeResult.Results
                                                  .Select(ConvertFeatureResult)
                                                  .ToArray(),
                                     ConvertError(analyzeResult.Error));
        }

        private static FeatureResult ConvertFeatureResult(Yandex.Cloud.Ai.Vision.V1.FeatureResult featureResult)
        {
            return new FeatureResult(ConvertError(featureResult.Error),
                                     new TextDetectionResult(featureResult.TextDetection
                                                                          .Pages
                                                                          .Select(ConvertPage)
                                                                          .ToArray()));
        }

        private static Page ConvertPage(Yandex.Cloud.Ai.Vision.V1.Page page)
        {
            return new Page(page.Width,
                            page.Height,
                            page.Blocks
                                .Select(ConvertBlock)
                                .ToArray());
        }

        private static Block ConvertBlock(Yandex.Cloud.Ai.Vision.V1.Block block)
        {
            return new Block(ConvertPolygon(block.BoundingBox),
                             block.Lines
                                  .Select(ConvertLine)
                                  .ToArray());
        }

        private static Line ConvertLine(Yandex.Cloud.Ai.Vision.V1.Line line)
        {
            return new Line(ConvertPolygon(line.BoundingBox),
                            line.Words
                                .Select(ConvertWord)
                                .ToArray(),
                            line.Confidence);
        }

        private static Word ConvertWord(Yandex.Cloud.Ai.Vision.V1.Word word)
        {
            return new Word(ConvertPolygon(word.BoundingBox),
                            word.Text,
                            word.Confidence,
                            word.Languages
                                .Select(ConvertLanguage)
                                .ToArray());
        }

        private static Language ConvertLanguage(Yandex.Cloud.Ai.Vision.V1.Word.Types.DetectedLanguage language)
        {
            return new Language(language.LanguageCode,
                                language.Confidence);
        }

        private static Polygon ConvertPolygon(Yandex.Cloud.Ai.Vision.V1.Polygon polygon)
        {
            return new Polygon(polygon.Vertices
                                      .Select(ConvertVertex)
                                      .ToArray());
        }

        private static Vertex ConvertVertex(Yandex.Cloud.Ai.Vision.V1.Vertex vertex)
        {
            return new Vertex(vertex.X, vertex.Y);
        }

        private static Error? ConvertError(Status error)
        {
            if (error == null)
            {
                return null;
            }

            return new Error(error.Code,
                             error.Message,
                             error.Details?.ToArray() ?? Array.Empty<object>());
        }
    }
}
