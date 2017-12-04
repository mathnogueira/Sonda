using System;
using System.Collections.Generic;
using System.Text;
using Domain.Exceptions;
using Domain.Entities;

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
                    throw new SondaException("Command '"+ command +"' not allowed");
            }
        }
    }
}
