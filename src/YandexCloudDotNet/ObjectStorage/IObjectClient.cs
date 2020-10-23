using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using YandexCloudDotNet.ObjectStorage.DTO;

namespace YandexCloudDotNet.ObjectStorage
{
    public interface IObjectClient
    {
        Task<ObjectUploadResult> Upload(string key, string bucketName, Stream stream,
                                          Dictionary<string, string> meta);

        Task<StoredObject?> Get(string key, string bucketName);
        Task Delete(string key, string bucketName);
    }
}
