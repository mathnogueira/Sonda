using System;
using System.Collections.Generic;
using System.IO;
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
            try
            {
                string filename = AskForInputFile();
                var configuration = LoadConfigurationFromFile(filename);
                var solutions = SolveProblem(configuration);
                ReportSolutions(solutions);
            }
            catch (Exception ex)
            {
                errorReporter.Report(ex);
            }
            finally
            {
                Finish();
            }
        }

        private string AskForInputFile()
        {
            Console.WriteLine("Digite o nome do arquivo com as definições do programa: ");
            return Console.ReadLine();
        }

        private ProblemConfiguration LoadConfigurationFromFile(string filename)
        {
            try
            {
                string input = File.ReadAllText(filename);
                return this.parser.Parse(input);
            } 
            catch (IOException ex)
            {
                throw new SondaMovementException("File does not exist!");
            }
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
