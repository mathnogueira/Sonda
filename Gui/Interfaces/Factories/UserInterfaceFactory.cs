namespace Gui.Interfaces.Factories
{
    public class UserInterfaceFactory : IUserInterfaceFactory
    {
        public IUserInterface Produce()
        {
            return new CommandLineInterface();
        }
    }
}
