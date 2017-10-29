using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Domain.Exceptions;
using Domain.Geometry;
using Domain.Parser;
using Domain.Solver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests.Solvers
{
    [TestClass]
    public class ProblemSolverTest
    {

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
            var solver = new ProblemSolver(configuration);

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
            var solver = new ProblemSolver(configuration);

            Assert.ThrowsException<SondaMovementException>(() =>
            {
                solver.Solve();
            });
        }
    }
}
