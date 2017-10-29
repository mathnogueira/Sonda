﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public interface ICommandFactory
    {
        ICommand Produce(char command);
    }
}
