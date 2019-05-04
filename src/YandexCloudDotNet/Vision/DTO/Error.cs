namespace YandexCloudDotNet.Vision.DTO
{
    public class Error
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public object[] Details { get; set; }
    }
}