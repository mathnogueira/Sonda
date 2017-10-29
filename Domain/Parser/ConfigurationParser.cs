using System.Collections.Generic;
using Domain.Geometry;
using Domain.Transformers;

namespace Domain.Parser
{
    public class ConfigurationParser
    {
        public ProblemConfiguration Parse(string configuration)
        {
            string[] lines = configuration.Split('\n');
            var terrainDimensions = GetTerrainDimensions(lines);
            var sondas = GetSondasConfiguration(lines);

            return new ProblemConfiguration(
                terrainDimensions.Width,
                terrainDimensions.Height,
                sondas);
        }

        private dynamic GetTerrainDimensions(string[] lines)
        {
            string[] dimensions = lines[0].Split(' ');
            int width = int.Parse(dimensions[0]);
            int height = int.Parse(dimensions[1]);
            return new { Width = width, Height = height };
        }

        private IList<SondaConfiguration> GetSondasConfiguration(string[] lines)
        {
            IList<SondaConfiguration> sondas = new List<SondaConfiguration>();
            int numberSondas = (lines.Length -1 ) / 2;
            for (int i = 0; i < numberSondas; ++i)
            {
                var sondaConfiguration = ExtractNthSondaConfiguration(lines, i);
                sondas.Add(sondaConfiguration);
            }
            return sondas;
        }

        private SondaConfiguration ExtractNthSondaConfiguration(string[] lines, int n)
        {
            string positionLine = lines[n * 2 + 1];
            string[] positionInfo = positionLine.Split(' ');
            dynamic sondaPosition = ExtractStartingPositionFromPositionInfo(positionInfo);

            string commandsLine = lines[n * 2 + 2];
            char[] commands = commandsLine.ToCharArray();
            IList<char> commandList = new List<char>(commands);

            return new SondaConfiguration(sondaPosition.StartingPoint, sondaPosition.StartingRotation, commandList);
        }

        private dynamic ExtractStartingPositionFromPositionInfo(string[] positionInfo)
        {
            int x = int.Parse(positionInfo[0]);
            int y = int.Parse(positionInfo[1]);
            char direction = char.Parse(positionInfo[2]);
            int degrees = CardinalTransformer.from(direction).toDegrees();

            return new
            {
                StartingPoint = new Point2d(x, y),
                StartingRotation = degrees
            };
        }
    }
}
