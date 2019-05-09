namespace YandexCloudDotNet.Vision.DTO
{
    public class Polygon
    {
        public Polygon(Vertex[] vertices)
        {
            Vertices = vertices;
        }

        public Vertex[] Vertices { get; }
    }
}
