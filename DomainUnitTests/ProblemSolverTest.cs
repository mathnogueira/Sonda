using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Domain.Geometry;
using Domain.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests
{
    [TestClass]
    public class ProblemSolverTest
    {

        [TestMethod]
        public void SolveProblem()
        {
            var sondas = new List<SondaConfiguration>
            {
                new SondaConfiguration(
                    new Point2d(0, 0),
                    90,
                    new List<char> { 'R', 'R', 'M' })
            };
            var configuration = new ProblemConfiguration(25, 30, sondas);
            var solver = new ProblemSolver(configuration);
        }
    }
}
