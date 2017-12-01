using System;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Geometry;

namespace Domain.Commands
{
    public class MoveCommand : Command
    {

        private Moveable target;

        public void SetTarget(Target target)
        {
            this.target = target as Moveable;
        }

        public void Execute()
        {
            var newPosition = GenerateNewPosition(target);
            target.MoveTo(newPosition);
        }

        private Point2d GenerateNewPosition(Moveable target)
        {
            int rotation = target.Rotation;
            double radians = rotation * Math.PI / 180;
            int xAxisMovement = (int)Math.Cos(radians);
            int yAxisMovement = (int)Math.Sin(radians);

            int newX = target.Position.X + xAxisMovement;
            int newY = target.Position.Y + yAxisMovement;

            return new Point2d(newX, newY);
        }
    }
}
