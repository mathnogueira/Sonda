using System;
using System.Collections.Generic;
using System.Text;
using Domain.Transformers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUnitTests.Transformers
{
    [TestClass]
    public class CardinalTransformerTest
    {

        [TestMethod]
        public void transformDirectionsIntoDegrees()
        {
            int eastDegrees = CardinalTransformer.from('E').toDegrees();
            int northDegrees = CardinalTransformer.from('N').toDegrees();
            int westDegrees = CardinalTransformer.from('W').toDegrees();
            int southDegrees = CardinalTransformer.from('S').toDegrees();

            Assert.AreEqual(0, eastDegrees);
            Assert.AreEqual(90, northDegrees);
            Assert.AreEqual(180, westDegrees);
            Assert.AreEqual(270, southDegrees);
        }

        [TestMethod]
        public void transformDegreesIntoDirection()
        {
            char eastDirection = CardinalTransformer.from(0).toCardinalDirection();
            char northDirection = CardinalTransformer.from(90).toCardinalDirection();
            char westDirection = CardinalTransformer.from(180).toCardinalDirection();
            char southDirection = CardinalTransformer.from(270).toCardinalDirection();

            Assert.AreEqual('E', eastDirection);
            Assert.AreEqual('N', northDirection);
            Assert.AreEqual('W', westDirection);
            Assert.AreEqual('S', southDirection);
        }

    }
}
