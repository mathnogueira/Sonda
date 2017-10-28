using Domain;
using Domain.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests
{
    [TestClass]
    public class WorldTest
    {

        [TestMethod]
        public void PointInsideWorld()
        {
            var rect = new Rectangle(15, 10, 8, 8);
            var world = new World(rect);
            var point = new Point2d(15, 15);

            bool containsPoint = world.Contains(point);

            Assert.IsTrue(containsPoint);
        }
    }
}
