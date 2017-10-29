﻿using System.Collections.Generic;
using Domain.Builders;
using Domain.Commands;
using Domain.Entities;
using Domain.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests.Builders
{
    [TestClass]
    public class SondaBuilderTest
    {

        private SondaBuilder builder;

        [TestInitialize]
        public void Setup()
        {
            var factory = new CommandFactoryMock();
            this.builder = new SondaBuilder(factory);
        }

        [TestMethod]
        public void BuildSonda()
        {
            var position = new Point2d(0, 3);
            int rotation = 180;
            var commands = new List<char> { 'A', 'B', 'C' };

            var sonda = this.builder
                .SetPosition(position)
                .SetRotation(rotation)
                .SetCommandList(commands)
                .Build();

            Assert.AreEqual(0, sonda.Position.X);
            Assert.AreEqual(3, sonda.Position.Y);
        }
    }

    class CommandFactoryMock : ICommandFactory
    {
        public ICommand Produce(char command)
        {
            return new MockCommand();
        }
    }

    class MockCommand : ICommand
    {

        public void Execute(ISonda target, IContainer container)
        {
            // Do nothing
        }
    }
}
