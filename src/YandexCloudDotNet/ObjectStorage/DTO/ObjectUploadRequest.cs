using System.Collections.Generic;
using System.IO;

namespace YandexCloudDotNet.ObjectStorage.DTO
{
    public class ObjectUploadRequest
    {
        public string Key { get; set; }
        public string BucketName { get; set; }
        public Stream Stream { get; set; }
        public Dictionary<string, string> Meta { get; set; }
    }
}
