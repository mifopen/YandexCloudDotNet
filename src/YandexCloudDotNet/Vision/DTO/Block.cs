namespace YandexCloudDotNet.Vision.DTO
{
    public class Block
    {
        public BoundingBox BoundingBox { get; set; }
        public Line[] Lines { get; set; }
    }
}