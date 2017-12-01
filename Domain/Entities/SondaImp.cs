using System.Collections.Generic;
using Domain.Commands;
using Domain.Geometry;
using Domain.Exceptions;
using System;

namespace Domain.Entities
{
    public class SondaImp : Sonda
    {
        public int Rotation { get; set; }
        public Point2d Position { get; set; }

        private IList<Command> commands;

        public SondaImp()
        {

        }

        public SondaImp(Point2d point, int rotation, IList<Command> commands)
        {
            this.Rotation = rotation;
            this.Position = point;
            this.commands = commands;
            if (commands != null)
            {
                SetCommandsTarget();
            }
        }

        private void SetCommandsTarget()
        {
            foreach (var command in this.commands)
            {
                command.SetTarget(this);
            }
        }

        public void MoveTo(Point2d position)
        {
            this.Position = position;
        }

        public void RotateTo(int degrees)
        {
            Rotation = degrees;
        }

        public void ExecuteCommands(Container container)
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
            ValidateSondaIsValidPosition(container);
        }

        private void ValidateSondaIsValidPosition(Container container)
        {
            if (!container.Contains(Position))
            {
                throw new SondaMovementException(
                    String.Format("Invalid movement position ({0}, {1})", Position.X, Position.Y)
                );
            }
        }
    }
}
