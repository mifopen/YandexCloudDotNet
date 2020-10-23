using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Yandex.Cloud.Iam.V1;
using Role = YandexCloudDotNet.IAM.DTO.Role;

namespace YandexCloudDotNet.IAM
{
    public class RoleClient: IRoleClient
    {
        public async Task<List<Role>> GetAll()
        {
            var channel = new Channel("iam.api.cloud.yandex.net", 443, new SslCredentials());
            var client = new RoleService.RoleServiceClient(channel);
            var request = new ListRolesRequest();
            var response = await client.ListAsync(request);
            return response.Roles
                           .Select(x => new Role
                                        {
                                            Id = x.Id,
                                            Desription = x.Description
                                        })
                           .ToList();
        }
    }
}
