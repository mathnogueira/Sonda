using Domain.Geometry;

namespace Domain.Entities
{
    public interface IMoveable
    {
        void MoveTo(Point2d position);

    }
}
