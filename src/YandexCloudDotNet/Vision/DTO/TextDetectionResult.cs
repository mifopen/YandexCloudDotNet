namespace YandexCloudDotNet.Vision.DTO
{
    public class TextDetectionResult
    {
        private TextDetectionResult() { }

        public TextDetectionResult(Page[] pages)
        {
            Pages = pages;
        }

        public Page[] Pages { get; }
    }
}
