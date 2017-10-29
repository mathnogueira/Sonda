using Domain.Entities;
using Domain.Geometry;

namespace Domain.Commands
{
    public interface ICommand
    {
        void Execute(ISonda target, IContainer container);
    }
}
