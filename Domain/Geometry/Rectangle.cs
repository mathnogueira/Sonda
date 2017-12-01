namespace Domain.Geometry
{
    public class Rectangle : Container
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        public bool Contains(Point2d point)
        {
            bool insideXAxisRange = IsInsideXAxisRange(point.X);
            bool insideYAxisRange = IsInsideYAxisRange(point.Y);

            return insideXAxisRange && insideYAxisRange;
        }

        private bool IsInsideXAxisRange(int x)
        {
            return x >= this.X && x <= this.X + this.Width;
        }

        private bool IsInsideYAxisRange(int y)
        {
            return y >= this.Y && y <= this.Y + this.Height;
        }
    }
}
