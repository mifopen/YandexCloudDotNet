namespace YandexCloudDotNet.Vision.DTO
{
    public class Language
    {
        public Language(string languageCode, double confidence)
        {
            LanguageCode = languageCode;
            Confidence = confidence;
        }

        public string LanguageCode { get; }
        public double Confidence { get; }
    }
}
