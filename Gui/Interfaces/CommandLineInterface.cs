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
    public class CommandLineInterface : UserInterface
    {
        private SolutionReporter solutionReporter;
        private ErrorReporter errorReporter;
        private ConfigurationParser parser;
        private ProblemSolverFactory problemSolverFactory;

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

        public void SetSolutionReporter(SolutionReporter reporter)
        {
            this.solutionReporter = reporter;
        }

        public void SetErrorReporter(ErrorReporter reporter)
        {
            this.errorReporter = reporter;
        }

        public void SetConfigurationParser(ConfigurationParser parser)
        {
            this.parser = parser;
        }

        public void SetProblemSolverFactory(ProblemSolverFactory factory)
        {
            this.problemSolverFactory = factory;
        }
    }
}
