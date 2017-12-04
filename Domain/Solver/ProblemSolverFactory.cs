using Domain.Parser;
using Domain.Commands;

namespace Domain.Solver
{
    public interface ProblemSolverFactory
    {
        ProblemSolver Produce(ProblemConfiguration configuration, CommandFactory commandFactory);
    }
}
