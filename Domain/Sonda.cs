using Domain.Geometry;

namespace Domain
{
    public class Sonda : IMoveable
    {
        public double rotation { get; set; }
        public Point2d Position { get; set; }

        public void MoveTo(Point2d position)
        {
            this.Position = position;
        }

        public void Rotate(int degrees)
        {
            rotation = rotation + degrees;
        }
    }
}
