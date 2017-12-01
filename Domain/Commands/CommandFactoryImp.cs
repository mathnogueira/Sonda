using System;
using System.Collections.Generic;
using System.Text;
using Domain.Exceptions;

namespace Domain.Commands
{
    public class CommandFactoryImp : CommandFactory
    {
        public Command Produce(char command)
        {
            switch (command)
            {
                case 'L':
                    return new RotateLeftCommand();
                case 'R':
                    return new RotateRightCommand();
                case 'M':
                    return new MoveCommand();
                default:
                    throw new SondaMovementException("Command '"+ command +"' not allowed");
            }
        }
    }
}
