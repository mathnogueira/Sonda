using Domain.Entities;
using Domain.Geometry;

namespace Domain.Commands
{
    public interface Command
    {
        void Execute(Sonda target, Container container);
    }
}
