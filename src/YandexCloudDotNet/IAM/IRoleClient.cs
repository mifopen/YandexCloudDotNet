using System.Collections.Generic;
using System.Threading.Tasks;
using YandexCloudDotNet.IAM.DTO;

namespace YandexCloudDotNet.IAM
{
    public interface IRoleClient
    {
        Task<List<Role>> GetAll();
    }
}
