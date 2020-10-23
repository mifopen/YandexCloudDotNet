using Amazon;
using Amazon.Runtime;
using Amazon.S3;

namespace YandexCloudDotNet.ObjectStorage
{
    public class ObjectStorageClient: IObjectStorageClient
    {
        private readonly IAmazonS3 amazonS3Client;
        public IBucketClient Bucket { get; }
        public IObjectClient Object { get; }

        public ObjectStorageClient(YandexCloudCredentials yandexCloudCredentials)
        {
            amazonS3Client = CreateClient(yandexCloudCredentials);
            Bucket = new BucketClient(amazonS3Client);
            Object = new ObjectClient(amazonS3Client);
        }

        private static IAmazonS3 CreateClient(YandexCloudCredentials yandexCloudCredentials)
        {
            var credentials = new BasicAWSCredentials(yandexCloudCredentials.SecretKeyId,
                                                      yandexCloudCredentials.SecretKey);
            var config = new AmazonS3Config
                         {
                             RegionEndpoint = RegionEndpoint.USEast1,
                             ServiceURL = "https://s3.yandexcloud.net"
                         };
            return new AmazonS3Client(credentials, config);
        }

        public void Dispose()
        {
            amazonS3Client.Dispose();
        }
    }
}
