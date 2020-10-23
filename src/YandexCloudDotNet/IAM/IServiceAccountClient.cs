using System.Threading.Tasks;

namespace YandexCloudDotNet.IAM
{
    public interface IServiceAccountClient
    {
        Task<string> Create(string folderId, string name, string description);
    }
}
