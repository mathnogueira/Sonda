using System;
using System.Collections.Generic;
using System.Text;
using Domain.Commands;
using Domain.Entities;
using Domain.Geometry;

namespace Domain.Builders
{
    public class SondaBuilder
    {

        private Point2d startingPosition;
        private int startingRotation;
        private IList<ICommand> commands;
        private ICommandFactory commandFactory;

        public SondaBuilder(ICommandFactory commandFactory)
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
            this.commands = new List<ICommand>();

            foreach (var commandCode in commandCodes)
            {
                var command = commandFactory.Produce(commandCode);
                this.commands.Add(command);
            }

            return this;
        }

        public Sonda Build()
        {
            return new Sonda(startingPosition, startingRotation, commands);
        }
    }
}
