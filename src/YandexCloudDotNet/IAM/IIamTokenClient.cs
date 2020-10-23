using System.IO;
using System.Threading.Tasks;

namespace YandexCloudDotNet.IAM
{
    public interface IIamTokenClient
    {
        Task<string> Get(string serviceAccountId,
                         string authorizationKeyId,
                         Stream privateKey);
    }
}
