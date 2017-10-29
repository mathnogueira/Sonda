using System;
using Domain.Exceptions;

namespace Gui.Reporters
{
    public interface IErrorReporter
    {
        void Report(Exception ex);
    }
}
