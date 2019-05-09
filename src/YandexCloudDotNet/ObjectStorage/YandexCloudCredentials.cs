namespace YandexCloudDotNet.ObjectStorage
{
    public class YandexCloudCredentials
    {
        public YandexCloudCredentials(string secretKeyId, string secretKey)
        {
            SecretKeyId = secretKeyId;
            SecretKey = secretKey;
        }

        public string SecretKeyId { get; }
        public string SecretKey { get; }
    }
}
