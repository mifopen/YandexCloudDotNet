using System.Collections.Generic;
using System.Threading.Tasks;
using YandexCloudDotNet.ObjectStorage.DTO;

namespace YandexCloudDotNet.ObjectStorage
{
    public interface IBucketClient
    {
        Task Create(string name);
        Task<List<Bucket>> GetAll();
        Task Delete(string name);
    }
}
