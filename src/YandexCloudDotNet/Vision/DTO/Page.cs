namespace YandexCloudDotNet.Vision.DTO
{
    public class Page
    {
        private Page() { }

        public Page(long width, long height, Block[] blocks)
        {
            Width = width;
            Height = height;
            Blocks = blocks;
        }

        public long Width { get; }
        public long Height { get; }
        public Block[] Blocks { get; }
    }
}
