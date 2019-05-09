using System;
using System.Collections.Generic;
using System.IO;
using Shouldly;
using Xunit;
using YandexCloudDotNet.ObjectStorage;
using YandexCloudDotNet.ObjectStorage.DTO;

namespace YandexCloudDotNet.Tests.ObjectStorage
{
    public class ObjectStorageClientTest: IDisposable
    {
        private readonly IObjectStorageClient client;

        public ObjectStorageClientTest()
        {
            var yandexCloudCredentials = new YandexCloudCredentialsProvider().Get();
            client = new ObjectStorageClient(yandexCloudCredentials);
        }

        [Fact]
        public async void Simple()
        {
            const string bucketName = "formula-test-bucket";
            var stream = new MemoryStream(new byte[]
                                          {
                                              1, 3, 2
                                          });
            var key = Guid.NewGuid().ToString();
            await client.Upload(new ObjectUploadRequest(key,
                                                        bucketName,
                                                        stream,
                                                        new Dictionary<string, string>
                                                        {
                                                            {
                                                                "Some", "thing"
                                                            }
                                                        }));

            var obj = await client.Get(new ObjectGetRequest(key, bucketName));
            obj.Stream.ReadByte().ShouldBe(1);
            obj.Stream.ReadByte().ShouldBe(3);
            obj.Stream.ReadByte().ShouldBe(2);
            obj.Meta.ContainsKey("Some").ShouldBeTrue();
            obj.Meta["Some"].ShouldBe("thing");

            await client.Delete(new ObjectDeleteRequest(key, bucketName));
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
