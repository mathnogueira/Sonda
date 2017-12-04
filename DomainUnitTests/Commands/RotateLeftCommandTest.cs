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
        private Command command;

        [TestInitialize]
        public void Setup()
        {
            origin = new Point2d(0, 0);
            command = new RotateLeftCommand();
        }

        [TestMethod]
        public void RotateLeftOnce()
        {
            var sonda = new SondaImp(origin, 0, null);

            command.SetTarget(sonda);
            command.Execute();

            Assert.AreEqual(90, sonda.Rotation);
        }
    }
}
