using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YandexCloudDotNet.Vision.DTO
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeatureType
    {
        TEXT_DETECTION,
        CLASSIFICATION,
        FACE_DETECTION
    }
}