namespace YandexCloudDotNet.Vision.DTO
{
    public class Line
    {
        public Line(Polygon boundingBox, Word[] words, double confidence)
        {
            BoundingBox = boundingBox;
            Words = words;
            Confidence = confidence;
        }

        public Polygon BoundingBox { get; }
        public Word[] Words { get; }
        public double Confidence { get; }
    }
}
