using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Gui.Reporters
{
    public interface ISolutionReporter
    {
        void Report(Solution solution);
    }
}
