using Domain.Geometry;

namespace Domain
{
    public interface IMoveable
    {
        void MoveTo(Point2d position);
        void Rotate(int degrees);
    }
}
