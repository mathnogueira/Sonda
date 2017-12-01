using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Geometry;

namespace Domain.Commands
{
    public class RotateLeftCommand : Command
    {
        public void Execute(Sonda target, Container container)
        {
            int rotation = target.Rotation;
            rotation = (rotation + 90) % 360;

            target.RotateTo(rotation);
        }
    }
}
