using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Gui.Reporters
{
    public class SolutionReporter : ISolutionReporter
    {
        public void Report(Solution solution)
        {
            string message = String.Format("{0} {1} {2}",
                solution.Position.X,
                solution.Position.Y,
                solution.Direction);

            Console.WriteLine(message);
        }
    }
}
