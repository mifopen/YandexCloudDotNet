namespace YandexCloudDotNet.Vision.DTO
{
    public class Word
    {
        public Word(Polygon boundingBox, string text, double confidence, Language[] languages)
        {
            BoundingBox = boundingBox;
            Text = text;
            Confidence = confidence;
            Languages = languages;
        }

        public Polygon BoundingBox { get; }
        public string Text { get; }
        public double Confidence { get; }
        public Language[] Languages { get; }
    }
}
