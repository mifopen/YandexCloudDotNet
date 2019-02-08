using System;
using System.Threading.Tasks;
using YandexCloudDotNet.ObjectStorage.DTO;

namespace YandexCloudDotNet.ObjectStorage
{
    public interface IObjectStorageClient : IDisposable
    {
        Task<ObjectUploadResponse> Upload(ObjectUploadRequest objectUploadRequest);
        Task<ObjectGetResponse> Get(ObjectGetRequest objectGetRequest);
        Task Delete(ObjectDeleteRequest objectDeleteRequest);
    }
}
