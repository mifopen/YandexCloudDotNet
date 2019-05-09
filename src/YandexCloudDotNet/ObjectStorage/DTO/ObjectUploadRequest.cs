using System.Collections.Generic;
using System.IO;

namespace YandexCloudDotNet.ObjectStorage.DTO
{
    public class ObjectUploadRequest
    {
        public ObjectUploadRequest(string key, string bucketName, Stream stream, Dictionary<string, string> meta)
        {
            Key = key;
            BucketName = bucketName;
            Stream = stream;
            Meta = meta;
        }

        public string Key { get; }
        public string BucketName { get; }
        public Stream Stream { get; }
        public Dictionary<string, string> Meta { get; }
    }
}
