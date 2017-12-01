using Domain.Parser;
using Domain.Solver;
using Gui.Reporters;

namespace Gui.Interfaces
{
    public interface UserInterface
    {
        void Start();
        void SetSolutionReporter(SolutionReporter reporter);
        void SetErrorReporter(ErrorReporter reporter);
        void SetConfigurationParser(ConfigurationParser parser);
        void SetProblemSolverFactory(ProblemSolverFactory solver);
    }
}
