using System.Threading.Tasks;
using YandexCloudDotNet.CertificateManager.DTO;
using YandexCloudDotNet.Common;

namespace YandexCloudDotNet.CertificateManager
{
    public interface ICertificateContentClient
    {
        Task<CertificateContent> Get(string certificateId, IAuthHeaders authHeaders);
    }
}
