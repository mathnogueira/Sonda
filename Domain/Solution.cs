using System;
using System.Collections.Generic;
using System.Text;
using Domain.Geometry;
using Domain.Transformers;

namespace Domain
{
    public class Solution
    {

        public Point2d Position { get; }
        public char Direction { get; }

        public Solution(Point2d position, int rotation)
        {
            this.Position = position;
            this.Direction = CardinalTransformer.from(rotation).toCardinalDirection();
        }
    }
}
