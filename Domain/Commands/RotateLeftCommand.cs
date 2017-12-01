using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Geometry;

namespace Domain.Commands
{
    public class RotateLeftCommand : Command
    {

        private Rotatable target;

        public void SetTarget(Target target)
        {
            this.target = target as Rotatable;
        }

        public void Execute()
        {
            int rotation = target.Rotation;
            rotation = (rotation + 90) % 360;

            target.RotateTo(rotation);
        }
    }
}
