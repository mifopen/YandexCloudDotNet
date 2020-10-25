using System.Threading.Tasks;
using Xunit;
using YandexCloudDotNet.CertificateManager;
using YandexCloudDotNet.Common;

namespace YandexCloudDotNet.Tests.CertificateManager
{
    public class CertificateManagerClientTest
    {
        private readonly ICertificateManagerClient client;
        private readonly SecretsProvider secretsProvider;

        public CertificateManagerClientTest()
        {
            secretsProvider = new SecretsProvider();
            client = new CertificateManagerClient();
        }

        [Fact]
        public async Task Simple()
        {
            var secrets = secretsProvider.Get();
            var content = await client.CertificateContent.Get("fpq3fvhrmjf3e3fans8f", new ApiKey(secrets.ApiKey));
            ;
        }
    }
}
