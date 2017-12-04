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
        private Command command;

        [TestInitialize]
        public void Setup()
        {
            origin = new Point2d(0, 0);
            command = new RotateRightCommand();
        }

        [TestMethod]
        public void RotateRightOnce()
        {
            var sonda = new SondaImp(origin, 0, null);

            command.SetTarget(sonda);
            command.Execute();

            Assert.AreEqual(270, sonda.Rotation);
        }

        [TestMethod]
        public void RotateRightThreeTimes()
        {
            var sonda = new SondaImp(this.origin, 0, null);

            command.SetTarget(sonda);
            command.Execute();
            command.Execute();
            command.Execute();

            Assert.AreEqual(90, sonda.Rotation);
        }
    }
}
