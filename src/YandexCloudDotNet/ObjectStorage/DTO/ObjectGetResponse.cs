using System.Collections.Generic;
using System.IO;

namespace YandexCloudDotNet.ObjectStorage.DTO
{
    public class ObjectGetResponse
    {
        public Stream Stream { get; set; }
        public Dictionary<string, string> Meta { get; set; }
    }
}
