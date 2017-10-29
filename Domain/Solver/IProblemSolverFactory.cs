using System;
using System.Collections.Generic;
using System.Text;
using Domain.Parser;

namespace Domain.Solver
{
    public interface IProblemSolverFactory
    {
        IProblemSolver Produce(ProblemConfiguration configuration);
    }
}
