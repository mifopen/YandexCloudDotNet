using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Yandex.Cloud.Certificatemanager.V1;
using YandexCloudDotNet.CertificateManager.DTO;
using YandexCloudDotNet.Common;

namespace YandexCloudDotNet.CertificateManager
{
    public class CertificateContentClient: ICertificateContentClient
    {
        public async Task<CertificateContent> Get(string certificateId, IAuthHeaders authHeaders)
        {
            var channel = new Channel("data.certificate-manager.api.cloud.yandex.net", 443, new SslCredentials());
            var client = new CertificateContentService.CertificateContentServiceClient(channel);
            var request = new GetCertificateContentRequest
                          {
                              CertificateId = certificateId
                          };
            var response = await client.GetAsync(request, authHeaders.ToMetadata());
            return new CertificateContent(
                id: response.CertificateId,
                chain: response.CertificateChain.ToArray(),
                privateKey: response.PrivateKey
            );
        }
    }
}
