using System;
using System.Collections.Generic;
using System.Text;
using Domain.Geometry;

namespace Domain.Entities
{
    public interface Sonda : Moveable, Rotatable
    {
        Point2d Position { get; }
        int Rotation { get; }
        void ExecuteCommands(Container container);
    }
}
