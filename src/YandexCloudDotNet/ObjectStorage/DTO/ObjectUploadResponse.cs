namespace YandexCloudDotNet.ObjectStorage.DTO
{
    public class ObjectUploadResponse
    {
        public ObjectUploadResponse(string eTag)
        {
            ETag = eTag;
        }

        public string ETag { get; }
    }
}
