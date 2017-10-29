using System;
using System.Collections.Generic;
using System.Text;
using Domain.Parser;

namespace Domain.Solver
{
    public class ProblemSolverFactory : IProblemSolverFactory
    {
        public IProblemSolver Produce(ProblemConfiguration configuration)
        {
            return new ProblemSolver(configuration);
        }
    }
}
