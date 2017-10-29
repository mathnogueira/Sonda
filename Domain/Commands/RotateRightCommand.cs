using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Geometry;

namespace Domain.Commands
{
    public class RotateRightCommand : ICommand
    {
        public void Execute(ISonda target, IContainer container)
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
