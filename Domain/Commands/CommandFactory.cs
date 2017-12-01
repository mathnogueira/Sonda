using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public interface CommandFactory
    {
        Command Produce(char command);
    }
}
