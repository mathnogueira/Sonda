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
    public class RotateRightCommandTest
    {

        private Point2d origin;

        [TestInitialize]
        public void Setup()
        {
            this.origin = new Point2d(0, 0);
        }

        [TestMethod]
        public void RotateRightOnce()
        {
            var sonda = new Sonda(this.origin, 0, null);
            var command = new RotateRightCommand();

            command.Execute(sonda, null);

            Assert.AreEqual(270, sonda.Rotation);
        }

        [TestMethod]
        public void RotateRightThreeTimes()
        {
            var sonda = new Sonda(this.origin, 0, null);
            var command = new RotateRightCommand();

            command.Execute(sonda, null);
            command.Execute(sonda, null);
            command.Execute(sonda, null);

            Assert.AreEqual(90, sonda.Rotation);
        }
    }
}
