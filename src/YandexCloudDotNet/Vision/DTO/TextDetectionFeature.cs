namespace YandexCloudDotNet.Vision.DTO
{
    public class TextDetectionFeature : Feature
    {
        public TextDetectionFeature()
        {
            this.Type = FeatureType.TEXT_DETECTION;
        }

        public TextDetectionConfig TextDetectionConfig { get; set; }
    }
}