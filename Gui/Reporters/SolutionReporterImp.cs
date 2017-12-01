using System;
using Domain;

namespace Gui.Reporters
{
    public class SolutionReporterImp : SolutionReporter
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
