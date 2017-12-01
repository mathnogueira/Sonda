using Domain.Commands;
using Domain.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests.Commands
{
    [TestClass]
    public class CommandFactoryTest
    {

        private CommandFactory factory;

        [TestInitialize]
        public void Setup()
        {
            this.factory = new CommandFactoryImp();
        }

        [TestMethod]
        public void ProduceMoveCommand()
        {
            var command = factory.Produce('M');
            Assert.IsInstanceOfType(command, typeof(MoveCommand));
        }

        [TestMethod]
        public void ProduceRotateRightCommand()
        {
            var command = factory.Produce('R');
            Assert.IsInstanceOfType(command, typeof(RotateRightCommand));
        }

        [TestMethod]
        public void ProduceRotateLeftCommand()
        {
            var command = factory.Produce('L');
            Assert.IsInstanceOfType(command, typeof(RotateLeftCommand));
        }

        [TestMethod]
        public void ProduceInvalidCommand()
        {
            Assert.ThrowsException<SondaMovementException>(() =>
            {
                factory.Produce('Q');
            });
        }
    }
}
