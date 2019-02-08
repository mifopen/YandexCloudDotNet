using Microsoft.Extensions.Configuration;
using YandexCloudDotNet.ObjectStorage;

namespace YandexCloudDotNet.Tests.ObjectStorage
{
    public class YandexCloudCredentialsProvider
    {
        public YandexCloudCredentials Get()
        {
            var configuration = new ConfigurationBuilder()
                                .AddUserSecrets<ObjectStorageClientTest>()
                                .Build();
            return new YandexCloudCredentials
                   {
                       SecretKeyId = configuration["YandexCloudSecretKeyId"],
                       SecretKey = configuration["YandexCloudSecretKey"]
                   };
        }
    }
}
