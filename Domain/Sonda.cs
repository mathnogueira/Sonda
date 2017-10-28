using Domain.Geometry;

namespace Domain
{
    public class Sonda : IMoveable
    {
        public Point2d Position;

        public void MoveTo(Point2d position)
        {
            this.Position = position;
        }
    }
}
