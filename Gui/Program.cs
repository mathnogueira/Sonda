using Domain.Parser;
using Domain.Solver;
using Gui.Interfaces.Factories;
using Gui.Reporters;

namespace Gui
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutionReporter = new SolutionReporterImp();
            var errorReporter = new ErrorReporterImp();
            var parser = new ConfigurationParserImp();
            var solverFactory = new ProblemSolverFactoryImp();

            var userInterfaceFactory = new UserInterfaceFactoryImp();
            var userInterface = userInterfaceFactory.Produce();

            userInterface.SetSolutionReporter(solutionReporter);
            userInterface.SetErrorReporter(errorReporter);
            userInterface.SetConfigurationParser(parser);
            userInterface.SetProblemSolverFactory(solverFactory);

            userInterface.Start();
        }
    }
}
