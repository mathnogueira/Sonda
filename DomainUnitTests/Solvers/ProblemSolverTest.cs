using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Domain.Exceptions;
using Domain.Geometry;
using Domain.Parser;
using Domain.Solver;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Domain.Commands;

namespace DomainUnitTests.Solvers
{
    [TestClass]
    public class ProblemSolverTest
    {

        private CommandFactory commandFactory;

        [TestInitialize]
        public void Setup()
        {
            commandFactory = new CommandFactoryImp();
        }

        [TestMethod]
        public void ValidSolution()
        {
            var sondas = new List<SondaConfiguration>
            {
                new SondaConfiguration(
                    new Point2d(0, 0),
                    90,
                    new List<char> { 'R', 'R', 'L', 'M' })
            };
            var configuration = new ProblemConfiguration(25, 30, sondas);
            var solver = new ProblemSolverImp(configuration, commandFactory);

            var solutions = solver.Solve();

            Assert.AreEqual(1, solutions[0].Position.X);
            Assert.AreEqual(0, solutions[0].Position.Y);
            Assert.AreEqual('E', solutions[0].Direction);
        }

        [TestMethod]
        public void InvalidPositionSolution()
        {
            var sondas = new List<SondaConfiguration>
            {
                new SondaConfiguration(
                    new Point2d(0, 0),
                    90,
                    new List<char> { 'R', 'R', 'M',  'R', 'M' })
            };
            var configuration = new ProblemConfiguration(25, 30, sondas);
            var solver = new ProblemSolverImp(configuration, commandFactory);

            Assert.ThrowsException<SondaException>(() =>
            {
                solver.Solve();
            });
        }
    }
}
