using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Geometry;

namespace Domain.Commands
{
    public class MoveCommand : ICommand
    {
        public void Execute(ISonda target, IContainer container)
        {
            var newPosition = GenerateNewPosition(target);
            if (!container.Contains(newPosition))
            {
                throw new SondaMovementException(
                    String.Format("Invalid movement position ({0}, {1})", newPosition.X, newPosition.Y)
                );
            }

            target.MoveTo(newPosition);
        }

        private Point2d GenerateNewPosition(ISonda target)
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
