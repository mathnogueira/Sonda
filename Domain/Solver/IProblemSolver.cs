using System.Collections.Generic;

namespace Domain.Solver
{
    public interface IProblemSolver
    {
        IList<Solution> Solve();
    }
}
