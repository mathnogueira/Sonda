using Domain.Commands;
using Domain.Geometry;

namespace Domain.Entities
{
    public interface Moveable : Rotatable, Target
    {
        Point2d Position { get; }
        void MoveTo(Point2d position);

    }
}
