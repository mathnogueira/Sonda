using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Domain.Exceptions;
using Domain.Parser;
using Domain.Solver;
using Gui.Reporters;

namespace Gui.Interfaces
{
    public class CommandLineInterface : IUserInterface
    {
        private ISolutionReporter solutionReporter;
        private IErrorReporter errorReporter;
        private IConfigurationParser parser;
        private IProblemSolverFactory problemSolverFactory;

        public void Start()
        {
            string filename = AskForInputFile();
            var configuration = LoadConfigurationFromFile(filename);
            var solutions = SolveProblem(configuration);
            ReportSolutions(solutions);
            Finish();
        }

        private string AskForInputFile()
        {
            Console.WriteLine("Digite o nome do arquivo com as definições do programa: ");
            return Console.ReadLine();
        }

        private ProblemConfiguration LoadConfigurationFromFile(string filename)
        {
            string input = File.ReadAllText(filename);
            return this.parser.Parse(input);
        }

        private IList<Solution> SolveProblem(ProblemConfiguration configuration)
        {
            IList<Solution> solutions = new List<Solution>();
            try
            {
                var solver = this.problemSolverFactory.Produce(configuration);
                solutions = solver.Solve();
            }
            catch (SondaMovementException ex)
            {
                this.errorReporter.Report(ex);
            }

            return solutions;
        }

        private void ReportSolutions(IList<Solution> solutions)
        {
            foreach (var solution in solutions)
            {
                this.solutionReporter.Report(solution);
            }
        }

        private void Finish()
        {
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }

        public void SetSolutionReporter(ISolutionReporter reporter)
        {
            this.solutionReporter = reporter;
        }

        public void SetErrorReporter(IErrorReporter reporter)
        {
            this.errorReporter = reporter;
        }

        public void SetConfigurationParser(IConfigurationParser parser)
        {
            this.parser = parser;
        }

        public void SetProblemSolverFactory(IProblemSolverFactory factory)
        {
            this.problemSolverFactory = factory;
        }
    }
}
