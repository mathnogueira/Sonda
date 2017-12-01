using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Geometry;

namespace Domain.Commands
{
    public class RotateRightCommand : Command
    {
        public void Execute(Sonda target, Container container)
        {
            int rotation = target.Rotation;
            rotation -= 90;
            if (rotation < 0)
            {
                rotation += 360;
            }

            target.RotateTo(rotation);
        }
    }
}
