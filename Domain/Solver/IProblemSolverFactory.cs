using Domain.Parser;

namespace Domain.Solver
{
    public interface IProblemSolverFactory
    {
        IProblemSolver Produce(ProblemConfiguration configuration);
    }
}
