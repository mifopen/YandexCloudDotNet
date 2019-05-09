namespace YandexCloudDotNet.Vision.DTO
{
    public class Block
    {
        public Block(Polygon boundingBox, Line[] lines)
        {
            BoundingBox = boundingBox;
            Lines = lines;
        }

        public Polygon BoundingBox { get; }
        public Line[] Lines { get; }
    }
}
