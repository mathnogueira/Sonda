using Domain.Geometry;

namespace Domain
{
    public class World : IWorld
    {
        private IContainer region;

        public World(IContainer container)
        {
            this.region = container;
        }

        public bool Contains(Point2d point)
        {
            return region.Contains(point);
        }
    }
}
