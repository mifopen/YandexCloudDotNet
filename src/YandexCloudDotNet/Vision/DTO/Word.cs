namespace YandexCloudDotNet.Vision.DTO
{
    public class Word
    {
        public BoundingBox BoundingBox { get; set; }
        public string Text { get; set; }
        public double Confidence { get; set; }
        public Language[] Languages { get; set; }
    }
}