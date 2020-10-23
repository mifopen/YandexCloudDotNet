using System.Threading.Tasks;
using Grpc.Core;
using Yandex.Cloud.Iam.V1;

namespace YandexCloudDotNet.IAM
{
    public class ServiceAccountClient: IServiceAccountClient
    {
        public async Task<string> Create(string folderId, string name, string description)
        {
            var channel = new Channel("iam.api.cloud.yandex.net", 443, new SslCredentials());
            var client = new ServiceAccountService.ServiceAccountServiceClient(channel);
            var request = new CreateServiceAccountRequest
                          {
                              Description = description,
                              FolderId = folderId,
                              Name = name
                          };
            var response = await client.CreateAsync(request);
            return response.Id;
        }
    }
}
