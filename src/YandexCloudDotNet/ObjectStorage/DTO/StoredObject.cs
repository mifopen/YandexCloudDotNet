using System.Collections.Generic;
using System.IO;

namespace YandexCloudDotNet.ObjectStorage.DTO
{
    public class StoredObject
    {
        public StoredObject(Stream stream, Dictionary<string, string> meta)
        {
            Stream = stream;
            Meta = meta;
        }

        public Stream Stream { get; }
        public Dictionary<string, string> Meta { get; }
    }
}
