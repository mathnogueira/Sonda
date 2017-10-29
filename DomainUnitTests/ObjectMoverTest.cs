using Domain;
using Domain.Exceptions;
using Domain.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests
{
    [TestClass]
    public class ObjectMoverTest
    {

        private Rectangle rect;
        private ObjectMover mover;

        [TestInitialize]
        public void Setup()
        {
            rect = new Rectangle(0, 0, 15, 15);
            mover = new ObjectMover(rect);
        }

        [TestMethod]
        public void ValidPositionMovement()
        {
            var sonda = new Sonda();
            var newPosition = new Point2d(10, 8);

            mover.Move(sonda, newPosition);

            Assert.AreEqual(sonda.Position.X, 10);
            Assert.AreEqual(sonda.Position.Y, 8);
        }

        [TestMethod]
        public void InvalidPositionMovement()
        {
            var sonda = new Sonda();
            var newPosition = new Point2d(-1, 15);

            Assert.ThrowsException<SondaMovementException>(() =>
            {
                mover.Move(sonda, newPosition);
            });
        }
    }
}
