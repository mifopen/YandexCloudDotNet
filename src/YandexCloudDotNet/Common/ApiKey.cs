using Grpc.Core;

namespace YandexCloudDotNet.Common
{
    public class ApiKey: IAuthHeaders
    {
        private readonly string apiKey;

        public ApiKey(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public Metadata ToMetadata()
        {
            return new Metadata
                   {
                       {
                           "Authorization", $"Api-Key {apiKey}"
                       }
                   };
        }
    }
}
