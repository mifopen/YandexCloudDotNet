namespace YandexCloudDotNet.IAM
{
    public interface IIamClient
    {
        IRoleClient Role { get; }
        IIamTokenClient IamToken { get; }
    }
}
