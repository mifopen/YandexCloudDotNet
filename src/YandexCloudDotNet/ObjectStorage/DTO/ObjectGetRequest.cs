namespace YandexCloudDotNet.ObjectStorage.DTO
{
    public class ObjectGetRequest
    {
        public ObjectGetRequest(string key, string bucketName)
        {
            Key = key;
            BucketName = bucketName;
        }

        public string Key { get; }
        public string BucketName { get; }
    }
}
