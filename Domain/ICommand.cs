namespace Domain
{
    public interface ICommand
    {
        void Execute(IMoveable target);
    }
}
