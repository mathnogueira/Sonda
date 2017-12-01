using System.Collections.Generic;

namespace Domain.Solver
{
    public interface ProblemSolver
    {
        IList<Solution> Solve();
    }
}
