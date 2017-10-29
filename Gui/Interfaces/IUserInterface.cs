using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Parser;
using Domain.Solver;
using Gui.Reporters;

namespace Gui.Interfaces
{
    public interface IUserInterface
    {
        void Start();
        void SetSolutionReporter(ISolutionReporter reporter);
        void SetErrorReporter(IErrorReporter reporter);
        void SetConfigurationParser(IConfigurationParser parser);
        void SetProblemSolverFactory(IProblemSolverFactory solver);
    }
}
