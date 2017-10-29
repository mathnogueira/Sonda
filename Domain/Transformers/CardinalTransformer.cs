using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Transformers
{
    public class CardinalTransformer
    {

        private char direction;
        private int degrees;

        public static CardinalTransformer from(char cardinalDirection)
        {
            return new CardinalTransformer(cardinalDirection);
        }

        public static CardinalTransformer from(int degrees)
        {
            return new CardinalTransformer(degrees);
        }

        private CardinalTransformer(char cardinalDirection)
        {
            this.direction = cardinalDirection;
        }

        private CardinalTransformer(int degrees)
        {
            this.degrees = degrees % 360;
        }

        public int toDegrees()
        {
            switch (this.direction)
            {
                case 'E':
                    return 0;
                case 'N':
                    return 90;
                case 'W':
                    return 180;
                case 'S':
                    return 270;
                default:
                    return 0;
            }
        }

        public char toCardinalDirection()
        {
            switch (this.degrees)
            {
                case 0:
                    return 'E';
                case 90:
                    return 'N';
                case 180:
                    return 'W';
                case 270:
                    return 'S';
                default:
                    return 'E';
            }
        }
    }
}
