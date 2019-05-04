using YandexCloudDotNet.ObjectStorage;

namespace YandexCloudDotNet.Tests.ObjectStorage
{
    public class YandexCloudCredentialsProvider
    {
        public YandexCloudCredentials Get()
        {
            var userSecretsProvider = new UserSecretsProvider();
            return new YandexCloudCredentials
                   {
                       SecretKeyId = userSecretsProvider.Get("YandexCloudSecretKeyId"),
                       SecretKey = userSecretsProvider.Get("YandexCloudSecretKey")
                   };
        }
    }
}
