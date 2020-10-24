using Grpc.Core;

namespace YandexCloudDotNet.Common
{
    public interface IAuthHeaders
    {
        Metadata ToMetadata();
    }
}
