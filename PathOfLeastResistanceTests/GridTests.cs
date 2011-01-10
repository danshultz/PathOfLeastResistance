using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using PathOfLeastResistanceLibrary;
using System.Data;


namespace PathOfLeastResistanceTests
{
    [TestFixture]
    public class GridTests
    {
        [Test, TestCaseSource(typeof(GridTestCases), "TestCases")]
        public PathResults VerifyThatTheWaterFindsThePathOfLeastResistance(int[,] arrayToTest)
        {
            return new Grid(arrayToTest).FindPathOfLeastResistance(new Water());
        }

        [Test]
        public void ArePathResultsComparedForEqualityProperly()
        {
            PathResults firstResults = new PathResults()
            {
                DidWaterFlowThroughEntireGrid = true,
                PathTaken = new List<int>(new int[] { 2, 4, 5, 1, 10 }),
                TotalResistance = 15
            };

            PathResults secondResults = new PathResults()
            {
                DidWaterFlowThroughEntireGrid = true,
                PathTaken = new List<int>(new int[] { 2, 4, 5, 1, 10 }),
                TotalResistance = 15
            };

            Assert.AreEqual(firstResults, secondResults, "The Two Paths Are Not Equal");
        }

        [Test]
        public void VerifyThatAGridCanTransformItselfIntoADataSet()
        {
            Grid grid = new Grid(new int[,]{{1, 5},
                                            {2, 6},
                                            {3, 7},
                                            {4, 8}});
            Assert.That(grid.Width == 2);
            Assert.That(grid.Height == 4);

            DataSet dataSet = grid.ToDataSet();
            Assert.That((int)dataSet.Tables[0].Rows[0][0] == 1);
            Assert.That((int)dataSet.Tables[0].Rows[0][1] == 5);
            Assert.That((int)dataSet.Tables[0].Rows[1][0] == 2);
            Assert.That((int)dataSet.Tables[0].Rows[1][1] == 6);
            Assert.That((int)dataSet.Tables[0].Rows[2][0] == 3);
            Assert.That((int)dataSet.Tables[0].Rows[2][1] == 7);
            Assert.That((int)dataSet.Tables[0].Rows[3][0] == 4);
            Assert.That((int)dataSet.Tables[0].Rows[3][1] == 8);
        }
    }
}
