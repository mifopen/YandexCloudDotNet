namespace YandexCloudDotNet.Vision.DTO
{
    public class ClassificationFeature : Feature
    {
        public ClassificationFeature()
        {
            this.Type = FeatureType.CLASSIFICATION;
        }

        public ClassificationConfig ClassificationConfig { get; set; }
    }
}