using System.Collections.Generic;
using Domain.Commands;
using Domain.Entities;
using Domain.Geometry;

namespace Domain.Builders
{
    public class SondaBuilder
    {

        private Point2d startingPosition;
        private int startingRotation;
        private IList<Command> commands;
        private CommandFactory commandFactory;

        public SondaBuilder(CommandFactory commandFactory)
        {
            this.commandFactory = commandFactory;
        }

        public SondaBuilder SetPosition(Point2d position)
        {
            this.startingPosition = position;
            return this;
        }

        public SondaBuilder SetRotation(int degrees)
        {
            this.startingRotation = degrees;
            return this;
        }

        public SondaBuilder SetCommandList(IList<char> commandCodes)
        {
            this.commands = new List<Command>();

            foreach (var commandCode in commandCodes)
            {
                var command = commandFactory.Produce(commandCode);
                this.commands.Add(command);
            }

            return this;
        }

        public SondaImp Build()
        {
            return new SondaImp(startingPosition, startingRotation, commands);
        }
    }
}
