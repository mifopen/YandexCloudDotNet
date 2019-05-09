namespace YandexCloudDotNet.Vision.DTO
{
    public class Vertex
    {
        public Vertex(long x, long y)
        {
            X = x;
            Y = y;
        }

        public long X { get; }
        public long Y { get; }
    }
}
