namespace YandexCloudDotNet.CertificateManager
{
    public class CertificateManagerClient: ICertificateManagerClient
    {
        public CertificateManagerClient()
        {
            Certificate = new CertificateClient();
            CertificateContent = new CertificateContentClient();
        }

        public ICertificateClient Certificate { get; }
        public ICertificateContentClient CertificateContent { get; }
    }
}
