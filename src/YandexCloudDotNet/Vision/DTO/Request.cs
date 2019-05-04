namespace YandexCloudDotNet.Vision.DTO
{
    public class Request
    {
        public AnalyzeSpec[] AnalyzeSpecs { get; set; }
        public string FolderId { get; set; }
    }
}