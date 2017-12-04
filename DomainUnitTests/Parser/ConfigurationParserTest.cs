using Domain.Parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests.Parser
{
    [TestClass]
    public class ConfigurationParserTest
    {

        private ConfigurationParser parser;

        [TestInitialize]
        public void Setup()
        {
            parser = new ConfigurationParserImp();
        }

        [TestMethod]
        public void ParseTerrainDimensions()
        {
            string input = "5 6\n";

            var configuration = parser.Parse(input);

            Assert.AreEqual(5, configuration.TerrainWidth);
            Assert.AreEqual(6, configuration.TerrainHeight);
        }

        [TestMethod]
        public void ParseSondas()
        {
            string input = "5 6\n1 2 N\nLMLMLMLMM\n3 3 E\nMMRMMRMRRM";

            var configuration = parser.Parse(input);

            Assert.AreEqual(2, configuration.Sondas.Count);

            Assert.AreEqual(9, configuration.Sondas[0].Commands.Count);
            Assert.AreEqual(1, configuration.Sondas[0].StartingPoint.X);
            Assert.AreEqual(2, configuration.Sondas[0].StartingPoint.Y);
            Assert.AreEqual(90, configuration.Sondas[0].StartingRotation);

            Assert.AreEqual(10, configuration.Sondas[1].Commands.Count);
            Assert.AreEqual(3, configuration.Sondas[1].StartingPoint.X);
            Assert.AreEqual(3, configuration.Sondas[1].StartingPoint.Y);
            Assert.AreEqual(0, configuration.Sondas[1].StartingRotation);
        }
    }
}
