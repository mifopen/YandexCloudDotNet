namespace YandexCloudDotNet.Vision.DTO
{
    public class Error
    {
        private Error() { }

        public Error(int code, string message, object[] details)
        {
            Code = code;
            Message = message;
            Details = details;
        }

        public int Code { get; }
        public string Message { get; }
        public object[] Details { get; }
    }
}
