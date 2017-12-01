namespace Gui.Interfaces.Factories
{
    public class UserInterfaceFactoryImp : UserInterfaceFactory
    {
        public UserInterface Produce()
        {
            return new CommandLineInterface();
        }
    }
}
