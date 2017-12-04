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
        private Command command;

        [TestInitialize]
        public void Setup()
        {
            origin = new Point2d(0, 0);
            terrain = new Rectangle(-15, -15, 20, 20);
            command = new MoveCommand();
        }

        [TestMethod]
        public void ExecuteMovementToEast()
        {
            var sonda = new SondaImp(this.origin, 0, null);

            command.SetTarget(sonda);
            command.Execute();

            Assert.AreEqual(1, sonda.Position.X);
            Assert.AreEqual(0, sonda.Position.Y);
        }

        [TestMethod]
        public void ExecuteMovementToNorth()
        {
            var sonda = new SondaImp(origin, 90, null);
            ExecuteOn(sonda);
            AssertPosition(new Point2d(0, 1), sonda);
        }

        [TestMethod]
        public void ExecuteMovementToWest()
        {
            var sonda = new SondaImp(origin, 180, null);
            ExecuteOn(sonda);
            AssertPosition(new Point2d(-1, 0), sonda);
        }

        [TestMethod]
        public void ExecuteMovementToSouth()
        {
            var sonda = new SondaImp(origin, 270, null);
            ExecuteOn(sonda);
            AssertPosition(new Point2d(0, -1), sonda);
        }

        private void ExecuteOn(Target target)
        {
            command.SetTarget(target);
            command.Execute();
        }

        private void AssertPosition(Point2d point, Sonda sonda)
        {
            Assert.AreEqual(point.X, sonda.Position.X);
            Assert.AreEqual(point.Y, sonda.Position.Y);
        }
    }
}
