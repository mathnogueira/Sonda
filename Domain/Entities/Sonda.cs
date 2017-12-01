using System;
using System.Collections.Generic;
using System.Text;
using Domain.Geometry;

namespace Domain.Entities
{
    public interface Sonda : Moveable, Rotatable
    {
        void ExecuteCommands(Container container);
    }
}
