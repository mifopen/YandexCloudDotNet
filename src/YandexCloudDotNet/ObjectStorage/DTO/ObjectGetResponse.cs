using System.Collections.Generic;
using System.IO;

namespace YandexCloudDotNet.ObjectStorage.DTO
{
    public class ObjectGetResponse
    {
        public ObjectGetResponse(Stream stream, Dictionary<string, string> meta)
        {
            Stream = stream;
            Meta = meta;
        }

        public Stream Stream { get; }
        public Dictionary<string, string> Meta { get; }
    }
}
