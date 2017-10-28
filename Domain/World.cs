using System;
using System.Collections.Generic;
using System.Text;
using Domain.Geometry;

namespace Domain
{
    public class World : IWorld
    {
        private IContainer region;

        public World(IContainer region)
        {
            this.region = region;
        }

        public bool Contains(Point2d point)
        {
            return region.Contains(point);
        }
    }
}
