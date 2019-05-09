namespace YandexCloudDotNet.ObjectStorage.DTO
{
    public class ObjectDeleteRequest
    {
        public ObjectDeleteRequest(string key, string bucketName)
        {
            Key = key;
            BucketName = bucketName;
        }

        public string Key { get; }
        public string BucketName { get; }
    }
}
