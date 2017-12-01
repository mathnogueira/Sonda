using Domain.Parser;

namespace Domain.Solver
{
    public class ProblemSolverFactoryImp : ProblemSolverFactory
    {
        public ProblemSolver Produce(ProblemConfiguration configuration)
        {
            return new ProblemSolverImp(configuration);
        }
    }
}
