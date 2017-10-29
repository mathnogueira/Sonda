using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Geometry;

namespace Domain.Commands
{
    public class RotateLeftCommand : ICommand
    {
        public void Execute(ISonda target, IContainer container)
        {
            int rotation = target.Rotation;
            rotation = (rotation + 90) % 360;

            target.RotateTo(rotation);
        }
    }
}
