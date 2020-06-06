namespace YandexCloudDotNet.Vision.DTO
{
    public class FeatureResult
    {
        private FeatureResult() { }

        public FeatureResult(Error? error, TextDetectionResult textDetection)
        {
            Error = error;
            TextDetection = textDetection;
        }

        public Error? Error { get; }
        public TextDetectionResult TextDetection { get; }
    }
}
