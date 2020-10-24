using System.Collections.Generic;
using System.Threading.Tasks;
using YandexCloudDotNet.CertificateManager.DTO;

namespace YandexCloudDotNet.CertificateManager
{
    public interface ICertificateClient
    {
        Task RequestNew(string folderId, string name, string description, Dictionary<string, string> labels, string[] domains, ChallengeType challengeType);
    }
}
