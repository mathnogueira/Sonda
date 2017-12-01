using Domain.Commands;
using Domain.Entities;
using Domain.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests.Commands
{
    [TestClass]
    public class MoveCommandTest
    {

        private Point2d origin;
        private Container terrain;

        [TestInitialize]
        public void Setup()
        {
            this.origin = new Point2d(0, 0);
            this.terrain = new Rectangle(-15, -15, 20, 20);
        }

        [TestMethod]
        public void ExecuteMovementToEast()
        {
            var sonda = new SondaImp(this.origin, 0, null);
            var command = new MoveCommand();

            command.Execute(sonda, terrain);

            Assert.AreEqual(1, sonda.Position.X);
            Assert.AreEqual(0, sonda.Position.Y);
        }

        [TestMethod]
        public void ExecuteMovementToNorth()
        {
            var sonda = new SondaImp(this.origin, 90, null);
            var command = new MoveCommand();

            command.Execute(sonda, terrain);

            Assert.AreEqual(0, sonda.Position.X);
            Assert.AreEqual(1, sonda.Position.Y);
        }

        [TestMethod]
        public void ExecuteMovementToWest()
        {
            var sonda = new SondaImp(this.origin, 180, null);
            var command = new MoveCommand();

            command.Execute(sonda, terrain);

            Assert.AreEqual(-1, sonda.Position.X);
            Assert.AreEqual(0, sonda.Position.Y);
        }

        [TestMethod]
        public void ExecuteMovementToSouth()
        {
            var sonda = new SondaImp(this.origin, 270, null);
            var command = new MoveCommand();

            command.Execute(sonda, terrain);

            Assert.AreEqual(0, sonda.Position.X);
            Assert.AreEqual(-1, sonda.Position.Y);
        }
    }
}
