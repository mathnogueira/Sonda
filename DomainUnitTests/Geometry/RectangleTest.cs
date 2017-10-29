using Domain.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests.Geometry
{
    [TestClass]
    public class RectangleTest
    {

        [TestMethod]
        public void HaveRightValues()
        {
            var rectangle = new Rectangle(0, 0, 7, 15);

            Assert.AreEqual(rectangle.X, 0);
            Assert.AreEqual(rectangle.Y, 0);
            Assert.AreEqual(rectangle.Width, 7);
            Assert.AreEqual(rectangle.Height, 15);
        }

        [TestMethod]
        public void PointInsideRectangle()
        {
            var rectangle = new Rectangle(0, 0, 10, 4);
            var point = new Point2d(8, 3);

            bool contains = rectangle.Contains(point);

            Assert.IsTrue(contains);
        }

        [TestMethod]
        public void PointOutsideRectangle()
        {
            var rectangle = new Rectangle(0, 0, 10, 4);
            var point1 = new Point2d(11, 3);
            var point2 = new Point2d(10, 5);

            bool containsPoint1 = rectangle.Contains(point1);
            bool containsPoint2 = rectangle.Contains(point2);

            Assert.IsFalse(containsPoint1);
            Assert.IsFalse(containsPoint2);
        }

        [TestMethod]
        public void PointOnRectangleBorder()
        {
            var rectangle = new Rectangle(0, 0, 10, 4);
            var point1 = new Point2d(0, 0);
            var point2 = new Point2d(10, 4);

            bool containsPoint1 = rectangle.Contains(point1);
            bool containsPoint2 = rectangle.Contains(point2);

            Assert.IsTrue(containsPoint1);
            Assert.IsTrue(containsPoint2);
        }
    }
}
