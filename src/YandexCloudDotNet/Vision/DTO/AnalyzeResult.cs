namespace YandexCloudDotNet.Vision.DTO
{
    public class AnalyzeResult
    {
#pragma warning disable 8618
        private AnalyzeResult() { }
#pragma warning restore 8618

        public AnalyzeResult(FeatureResult[] results, Error? error)
        {
            Results = results;
            Error = error;
        }

        public FeatureResult[] Results { get; }
        public Error? Error { get; }
    }
}
