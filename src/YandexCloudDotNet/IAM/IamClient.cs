namespace YandexCloudDotNet.IAM
{
    public class IamClient: IIamClient
    {
        public IamClient()
        {
            Role = new RoleClient();
            IamToken = new IamTokenClient();
        }

        public IRoleClient Role { get; }
        public IIamTokenClient IamToken { get; }
    }
}
