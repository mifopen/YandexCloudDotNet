using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Shouldly;
using Xunit;
using YandexCloudDotNet.ObjectStorage;

namespace YandexCloudDotNet.Tests.ObjectStorage
{
    public class ObjectStorageClientTest: IDisposable
    {
        private readonly IObjectStorageClient client;

        public ObjectStorageClientTest()
        {
            var secrets = new SecretsProvider().Get();
            client = new ObjectStorageClient(secrets.AccessKeyId, secrets.AccessKey);
        }

        [Fact]
        public async void Simple()
        {
            var bucketName = $"test-{Guid.NewGuid()}";

            (await client.Bucket.GetAll()).ShouldBeEmpty();

            await client.Bucket.Create(bucketName);

            var buckets = await client.Bucket.GetAll();
            buckets.ShouldHaveSingleItem();
            buckets.Single().Name.ShouldBe(bucketName);


            var stream = new MemoryStream(new byte[]
                                          {
                                              1, 3, 2
                                          });
            var key = Guid.NewGuid().ToString();

            var result = await client.Object.Get(key, bucketName);
            result.ShouldBeNull();

            await client.Object.Upload(key,
                                       bucketName,
                                       stream,
                                       new Dictionary<string, string>
                                       {
                                           {
                                               "Some", "thing"
                                           }
                                       });

            var obj = await client.Object.Get(key, bucketName);
            obj.ShouldNotBeNull();
            obj!.Stream.ReadByte().ShouldBe(1);
            obj.Stream.ReadByte().ShouldBe(3);
            obj.Stream.ReadByte().ShouldBe(2);
            obj.Meta.ContainsKey("Some").ShouldBeTrue();
            obj.Meta["Some"].ShouldBe("thing");

            await client.Object.Delete(key, bucketName);

            result = await client.Object.Get(key, bucketName);
            result.ShouldBeNull();

            await client.Bucket.Delete(bucketName);

            (await client.Bucket.GetAll()).ShouldBeEmpty();
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
