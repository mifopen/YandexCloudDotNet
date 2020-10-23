using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using YandexCloudDotNet.ObjectStorage.DTO;

namespace YandexCloudDotNet.ObjectStorage
{
    public class BucketClient: IBucketClient
    {
        private readonly IAmazonS3 amazonS3Client;

        public BucketClient(IAmazonS3 amazonS3Client)
        {
            this.amazonS3Client = amazonS3Client;
        }

        public async Task Create(string name)
        {
            var request = new PutBucketRequest
                          {
                              BucketName = name
                          };
            await amazonS3Client.PutBucketAsync(request)
                                .ConfigureAwait(false);
        }

        public async Task<List<Bucket>> GetAll()
        {
            var response = await amazonS3Client.ListBucketsAsync();
            return response.Buckets
                           .Select(x => new Bucket
                                        {
                                            Name = x.BucketName,
                                            CreatedAt = x.CreationDate
                                        })
                           .ToList();
        }

        public async Task Delete(string name)
        {
            var request = new DeleteBucketRequest
                          {
                              BucketName = name
                          };
            await amazonS3Client.DeleteBucketAsync(request);
        }
    }
}
