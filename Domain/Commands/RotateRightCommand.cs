using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Geometry;

namespace Domain.Commands
{
    public class RotateRightCommand : Command
    {

        private Rotatable target;

        public void SetTarget(Target target)
        {
            this.target = target as Rotatable;
        }

        public void Execute()
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
