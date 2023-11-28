namespace BridgePattern.Concretes
{
    public class RectangleData
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public RectangleData(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}