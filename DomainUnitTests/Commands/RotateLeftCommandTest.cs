using System;
using System.Collections.Generic;
using System.Text;
using Domain.Commands;
using Domain.Entities;
using Domain.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests.Commands
{
    [TestClass]
    public class RotateLeftCommandTest
    {

        private Point2d origin;

        [TestInitialize]
        public void Setup()
        {
            this.origin = new Point2d(0, 0);
        }

        [TestMethod]
        public void RotateLeftOnce()
        {
            var sonda = new Sonda(this.origin, 0, null);
            var command = new RotateLeftCommand();

            command.Execute(sonda, null);

            Assert.AreEqual(90, sonda.Rotation);
        }
    }
}
