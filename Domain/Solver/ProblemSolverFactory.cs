using Domain.Parser;

namespace Domain.Solver
{
    public interface ProblemSolverFactory
    {
        ProblemSolver Produce(ProblemConfiguration configuration);
    }
}
