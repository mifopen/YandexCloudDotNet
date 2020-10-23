namespace YandexCloudDotNet.ObjectStorage.DTO
{
    public class ObjectUploadResult
    {
        public ObjectUploadResult(string eTag)
        {
            ETag = eTag;
        }

        public string ETag { get; }
    }
}
