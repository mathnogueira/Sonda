using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Geometry
{
    public interface IContainer
    {
        bool Contains(Point2d point);
    }
}
