using Domain;
using Domain.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests
{
    [TestClass]
    public class SondaTest
    {
        [TestMethod]
        public void MovedToRightPlace()
        {
            var sonda = new Sonda();
            var position = new Point2d(3, 5);

            sonda.MoveTo(position);

            Assert.AreEqual(sonda.Position.X, 3);
            Assert.AreEqual(sonda.Position.Y, 5);
        }
    }
}
