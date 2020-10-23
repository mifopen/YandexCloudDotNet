using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using YandexCloudDotNet.ObjectStorage.DTO;

namespace YandexCloudDotNet.ObjectStorage
{
    public class ObjectClient: IObjectClient
    {
        private readonly IAmazonS3 amazonS3Client;

        public ObjectClient(IAmazonS3 amazonS3Client)
        {
            this.amazonS3Client = amazonS3Client;
        }

        public async Task<ObjectUploadResult> Upload(string key, string bucketName, Stream stream, Dictionary<string, string> meta)
        {
            var request = new PutObjectRequest
                          {
                              Key = key,
                              BucketName = bucketName,
                              InputStream = stream
                          };
            foreach (var pair in meta)
            {
                request.Metadata.Add(pair.Key, pair.Value);
            }

            var response = await amazonS3Client.PutObjectAsync(request)
                                               .ConfigureAwait(false);
            return new ObjectUploadResult(response.ETag);
        }

        public async Task<StoredObject?> Get(string key, string bucketName)
        {
            var request = new GetObjectRequest
                          {
                              Key = key,
                              BucketName = bucketName
                          };

            try
            {
                var response = await amazonS3Client.GetObjectAsync(request)
                                                   .ConfigureAwait(false);
                return new StoredObject(response.ResponseStream,
                                        response.Metadata.Keys
                                                .ToDictionary(x => x.Remove(0, 11), // x-amz-meta- = 11
                                                              x => response.Metadata[x]));
            }
            catch (AmazonS3Exception ex) when(ex.StatusCode == HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task Delete(string key, string bucketName)
        {
            var request = new DeleteObjectRequest
                          {
                              Key = key,
                              BucketName = bucketName
                          };

            await amazonS3Client.DeleteObjectAsync(request)
                                .ConfigureAwait(false);
        }

    }
}
