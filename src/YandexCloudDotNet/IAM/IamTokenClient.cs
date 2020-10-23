using System;
using System.IO;
using System.Threading.Tasks;
using Grpc.Core;
using Yandex.Cloud.Iam.V1;

namespace YandexCloudDotNet.IAM
{
    public class IamTokenClient: IIamTokenClient
    {
        public async Task<string> Get(string serviceAccountId,
                                      string authorizationKeyId,
                                      Stream privateKey)
        {
            var channel = new Channel("iam.api.cloud.yandex.net", 443, new SslCredentials());
            var client = new IamTokenService.IamTokenServiceClient(channel);
            var jwt = new JwtCreator().Create(serviceAccountId,
                                              authorizationKeyId,
                                              privateKey,
                                              TimeSpan.FromMinutes(2));
            var response = await client.CreateAsync(new CreateIamTokenRequest
                                                    {
                                                        Jwt = jwt
                                                    }).ResponseAsync;
            return response.IamToken;
        }
    }
}
