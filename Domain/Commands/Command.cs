using Domain.Entities;
using Domain.Geometry;

namespace Domain.Commands
{
    public interface Command
    {
        void SetTarget(Target target);
        void Execute();
    }
}
