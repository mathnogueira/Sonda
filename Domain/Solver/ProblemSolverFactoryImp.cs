using Domain.Parser;
using Domain.Commands;

namespace Domain.Solver
{
    public class ProblemSolverFactoryImp : ProblemSolverFactory
    {
        public ProblemSolver Produce(ProblemConfiguration configuration, CommandFactory commandFactory)
        {
            return new ProblemSolverImp(configuration, commandFactory);
        }
    }
}
