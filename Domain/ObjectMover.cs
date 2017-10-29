using Domain.Exceptions;
using Domain.Geometry;

namespace Domain
{
    public class ObjectMover
    {
        private IContainer terrain;

        public ObjectMover(IContainer terrain)
        {
            this.terrain = terrain;
        }

        public void Move(IMoveable item, Point2d position)
        {
            if (!terrain.Contains(position))
            {
                throw new SondaMovementException("Invalid movement position");
            }

            item.MoveTo(position);
        }

        public void Rotate(IMoveable item, int ammount)
        {
            item.Rotate(ammount);
        }
    }
}
