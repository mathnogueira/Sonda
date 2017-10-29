using System;
using System.Collections.Generic;
using System.Text;
using Domain.Geometry;

namespace Domain.Parser
{
    public class ProblemConfiguration
    {
        public readonly int TerrainWidth;
        public readonly int TerrainHeight;
        public readonly IList<SondaConfiguration> Sondas;

        public ProblemConfiguration(int terrainWidth, int terrainHeight, IList<SondaConfiguration> sondas)
        {
            this.TerrainWidth = terrainWidth;
            this.TerrainHeight = terrainHeight;
            this.Sondas = sondas;
        }

    }
}
