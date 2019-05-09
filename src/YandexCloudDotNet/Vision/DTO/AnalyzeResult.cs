namespace YandexCloudDotNet.Vision.DTO
{
    public class AnalyzeResult
    {
        public AnalyzeResult(FeatureResult[] results, Error? error)
        {
            Results = results;
            Error = error;
        }

        public FeatureResult[] Results { get; }
        public Error? Error { get; }
    }
}
