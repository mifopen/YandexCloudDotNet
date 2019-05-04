namespace YandexCloudDotNet.Vision.DTO
{
    public class Line
    {
        public BoundingBox BoundingBox { get; set; }
        public Word[] Words { get; set; }
        public double Confidence { get; set; }
    }
}