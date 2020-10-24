using Grpc.Core;

namespace YandexCloudDotNet.Common
{
    public class IamToken: IAuthHeaders
    {
        private readonly string iamToken;

        public IamToken(string iamToken)
        {
            this.iamToken = iamToken;
        }

        public Metadata ToMetadata()
        {
            return new Metadata
                   {
                       {
                           "Authorization", $"Bearer {iamToken}"
                       }
                   };
        }
    }
}
