using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PathOfLeastResistanceLibrary;
using System.Collections;

namespace PathOfLeastResistanceTests
{
    [TestFixture]
    public class WaterTests
    {
        [Test]
        public void GivenThreePathsWaterWillTakeThePathOfLeastResistance()
        {
            Water water = new Water();
            int path = water.Flow(2, 15, 1);
            Assert.AreEqual(1, path, "Water failed to pick the path of least resistance");
        }

        [Test]
        public void WaterThrowsResistanceTooHighExceptionWhenWatersResistanceIsTooHigh()
        {
            Water water = new Water();
            water.Flow(new int[] { 27, 28, 29 });
            Assert.Catch<ResistanceTooHighException>(delegate { water.Flow(new int[] { 27, 28, 29 }); });
        }
    }
}
