using System;
using System.Collections.Generic;
using System.IO;
using Domain;
using Domain.Exceptions;
using Domain.Parser;
using Domain.Solver;
using Gui.Interfaces;
using Gui.Interfaces.Factories;
using Gui.Reporters;

namespace Gui
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutionReporter = new SolutionReporter();
            var errorReporter = new ErrorReporter();
            var parser = new ConfigurationParser();
            var solverFactory = new ProblemSolverFactory();

            var userInterfaceFactory = new UserInterfaceFactory();
            var userInterface = userInterfaceFactory.Produce();

            userInterface.SetSolutionReporter(solutionReporter);
            userInterface.SetErrorReporter(errorReporter);
            userInterface.SetConfigurationParser(parser);
            userInterface.SetProblemSolverFactory(solverFactory);

            userInterface.Start();
        }
    }
}
