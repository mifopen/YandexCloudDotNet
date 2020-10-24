namespace YandexCloudDotNet.CertificateManager.DTO
{
    public class CertificateContent
    {
        public CertificateContent(string id, string[] chain, string privateKey)
        {
            Id = id;
            Chain = chain;
            PrivateKey = privateKey;
        }

        public string Id { get; }
        public string[] Chain { get; }
        public string PrivateKey { get; }
    }
}
