namespace YandexCloudDotNet.Vision.DTO
{
    public class TextDetectionResult
    {
        public TextDetectionResult(Page[] pages)
        {
            Pages = pages;
        }

        public Page[] Pages { get; }
    }
}
