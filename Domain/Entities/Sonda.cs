using System.Collections.Generic;
using Domain.Commands;
using Domain.Geometry;

namespace Domain.Entities
{
    public class Sonda : ISonda
    {
        public int Rotation { get; set; }
        public Point2d Position { get; set; }

        private IList<ICommand> commands;

        public Sonda()
        {

        }

        public Sonda(Point2d point, int rotation, IList<ICommand> commands)
        {
            this.Rotation = rotation;
            this.Position = point;
            this.commands = commands;
        }

        public void MoveTo(Point2d position)
        {
            this.Position = position;
        }

        public void RotateTo(int degrees)
        {
            Rotation = degrees;
        }

        public void ExecuteCommands(IContainer container)
        {
            foreach (var command in commands)
            {
                command.Execute(this, container);
            }
        }
    }
}
