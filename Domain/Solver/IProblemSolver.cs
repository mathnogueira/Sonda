using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Solver
{
    public interface IProblemSolver
    {
        IList<Solution> Solve();
    }
}
