using System.Threading.Tasks;
using Xunit;
using YandexCloudDotNet.CertificateManager;
using YandexCloudDotNet.Common;

namespace YandexCloudDotNet.Tests.CertificateManager
{
    public class CertificateManagerClientTest
    {
        private readonly ICertificateManagerClient client;
        private readonly UserSecretsProvider userSecretsProvider;

        public CertificateManagerClientTest()
        {
            userSecretsProvider = new UserSecretsProvider();
            client = new CertificateManagerClient();
        }

        [Fact]
        public async Task Simple()
        {
            var apiKey = userSecretsProvider.Get("YandexCloudTestServiceAccountApiKey");
            var content = await client.CertificateContent.Get("fpq3fvhrmjf3e3fans8f", new ApiKey(apiKey));
            ;
        }
    }
}
