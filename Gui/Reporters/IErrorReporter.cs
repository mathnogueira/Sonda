using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Exceptions;

namespace Gui.Reporters
{
    public interface IErrorReporter
    {
        void Report(SondaMovementException ex);
    }
}
