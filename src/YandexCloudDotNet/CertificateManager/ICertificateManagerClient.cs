namespace YandexCloudDotNet.CertificateManager
{
    public interface ICertificateManagerClient
    {
        ICertificateClient Certificate { get; }
        ICertificateContentClient CertificateContent { get; }
    }
}
