using System;
using System.Collections.Generic;
using System.Text;
using Domain.Geometry;

namespace Domain.Parser
{
    public class SondaConfiguration
    {
        public readonly Point2d StartingPoint;
        public readonly int StartingRotation;
        public readonly IList<char> Commands;

        public SondaConfiguration(Point2d startingPoint, int startingRotation, IList<char> commands)
        {
            this.StartingPoint = startingPoint;
            this.StartingRotation = startingRotation;
            this.Commands = commands;
        }
    }
}
