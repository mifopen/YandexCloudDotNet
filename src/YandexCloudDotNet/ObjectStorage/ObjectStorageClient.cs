using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using YandexCloudDotNet.ObjectStorage.DTO;

namespace YandexCloudDotNet.ObjectStorage
{
    public class ObjectStorageClient : IObjectStorageClient
    {
        private readonly IAmazonS3 amazonS3Client;

        public ObjectStorageClient(YandexCloudCredentials yandexCloudCredentials)
        {
            amazonS3Client = GetClient(yandexCloudCredentials);
        }

        public async Task<ObjectUploadResponse> Upload(ObjectUploadRequest objectUploadRequest)
        {
            var request = new PutObjectRequest
                          {
                              Key = objectUploadRequest.Key,
                              BucketName = objectUploadRequest.BucketName,
                              InputStream = objectUploadRequest.Stream
                          };
            foreach (var pair in objectUploadRequest.Meta)
            {
                request.Metadata.Add(pair.Key, pair.Value);
            }

            var response = await amazonS3Client.PutObjectAsync(request)
                                               .ConfigureAwait(false);
            return new ObjectUploadResponse
                   {
                       ETag = response.ETag
                   };
        }

        public async Task<ObjectGetResponse> Get(ObjectGetRequest objectGetRequest)
        {
            var request = new GetObjectRequest
                          {
                              Key = objectGetRequest.Key,
                              BucketName = objectGetRequest.BucketName
                          };

            var response = await amazonS3Client.GetObjectAsync(request)
                                               .ConfigureAwait(false);
            return new ObjectGetResponse
                   {
                       Stream = response.ResponseStream,
                       Meta = response.Metadata.Keys.ToDictionary(x => x.Remove(0, 11), // x-amz-meta- = 11
                                                                  x => response.Metadata[x])
                   };
        }

        public async Task Delete(ObjectDeleteRequest objectDeleteRequest)
        {
            var request = new DeleteObjectRequest
                          {
                              Key = objectDeleteRequest.Key,
                              BucketName = objectDeleteRequest.BucketName
                          };

            await amazonS3Client.DeleteObjectAsync(request)
                                .ConfigureAwait(false);
        }

        private static IAmazonS3 GetClient(YandexCloudCredentials yandexCloudCredentials)
        {
            var credentials = new BasicAWSCredentials(yandexCloudCredentials.SecretKeyId,
                                                      yandexCloudCredentials.SecretKey);
            var config = new AmazonS3Config
                         {
                             RegionEndpoint = RegionEndpoint.USEast1,
                             ServiceURL = "https://storage.yandexcloud.net"
                         };
            return new AmazonS3Client(credentials, config);
        }

        public void Dispose()
        {
            amazonS3Client?.Dispose();
        }
    }
}
