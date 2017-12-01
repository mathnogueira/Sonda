using System;
using Domain.Exceptions;

namespace Gui.Reporters
{
    public interface ErrorReporter
    {
        void Report(Exception ex);
    }
}
