﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using NUnit.Framework;
using PathOfLeastResistanceLibrary;

namespace PathOfLeastResistanceTests
{
    public class GridTestCases
    {
        public static IEnumerable<TestCaseData> TestCases
        {
            get
            {
                yield return new TestCaseData(new int[,]{{3, 5, 8, 1, 9, 2},
                                                         {2, 4, 2, 6, 8, 1},
                                                         {9, 5, 1, 9, 4, 7}})
                                                         .Returns(new PathResults()
                                                         {
                                                             DidWaterFlowThroughEntireGrid = true,
                                                             PathTaken = new List<int>(new int[] { 2, 2, 3, 1, 3, 2 }),
                                                             TotalResistance = 2 + 4 + 1 + 1 + 4 + 1
                                                         })
                                                         .SetName("6 x 3 grid test, with no negative numbers");
                yield return new TestCaseData(new int[,]{{3},
                                                         {2},
                                                         {9},
                                                         {-5}})
                                                         .Returns(new PathResults()
                                                         {
                                                             DidWaterFlowThroughEntireGrid = true,
                                                             PathTaken = new List<int>(new int[] { 4 }),
                                                             TotalResistance = -5
                                                         })
                                                         .SetName("Single Column Grid with Single Negative Number");
                yield return new TestCaseData(new int[,]{{3, 4, 8, 1, 5},
                                                         {2, 9, 9, 2, 2},
                                                         {9, 9, 1, 9, 9},
                                                         {5, 1, 5, 8, 7},
                                                         {9, 2, 2, 5, 9}})
                                                         .Returns(new PathResults()
                                                         {
                                                             DidWaterFlowThroughEntireGrid = true,
                                                             PathTaken = new List<int>(new int[] { 2, 1, 5, 1, 2 }),
                                                             TotalResistance = 2 + 4 + 2 + 1 + 2
                                                         })
                                                         .SetName("5 x 5 grid to test column wrapping.");
                yield return new TestCaseData(new int[,]{{3, 4, 1, 2, 8, 6},
                                                         {6, 1, 8, 2, 7, 4},
                                                         {5, 9, 3, 9, 9, 5},
                                                         {8, 4, 1, 3, 2, 6},
                                                         {3, 7, 2, 8, 6, 4}})
                                                         .Returns(new PathResults()
                                                         {
                                                             DidWaterFlowThroughEntireGrid = true,
                                                             PathTaken = new List<int>(new int[] { 1, 2, 1, 1, 5, 5 }),
                                                             TotalResistance = 3 + 1 + 1 + 2 + 6 + 4
                                                         })
                                                         .SetName("LeanDog Example One.");
                yield return new TestCaseData(new int[,]{{3, 4, 1, 2, 8, 6},
                                                         {6, 1, 8, 2, 7, 4},
                                                         {5, 9, 3, 9, 9, 5},
                                                         {8, 4, 1, 3, 2, 6},
                                                         {3, 7, 2, 1, 2, 3}})
                                                         .Returns(new PathResults()
                                                         {
                                                             DidWaterFlowThroughEntireGrid = true,
                                                             PathTaken = new List<int>(new int[] { 1, 2, 1, 5, 4, 5 }),
                                                             TotalResistance = 3 + 1 + 1 + 1 + 2 + 3
                                                         })
                                                         .SetName("LeanDog Example Two.");
                yield return new TestCaseData(new int[,]{{19, 10, 19, 10, 19},
                                                         {21, 23, 20, 19, 12},
                                                         {20, 12, 20, 11, 10}})
                                                         .Returns(new PathResults()
                                                         {
                                                             DidWaterFlowThroughEntireGrid = false,
                                                             PathTaken = new List<int>(new int[] { 1, 1, 1 }),
                                                             TotalResistance = 19 + 10 + 19
                                                         })
                                                         .SetName("LeanDog Failure Test Case From Document.");
                yield return new TestCaseData(new int[,]{{-4, -24, -7, 9, 19, 23, -14, -4, 13, 13, 23, -10, -12, 14, 15, -13, -21, -13, 20, 16, -7, 12, 6, 6, 17, -23, -4, 5, 19, 17, -12, 12, 9, -21, 19, 17, -17, 8, 14, 15, 17, -13, -25, 13, -21, -15, 18, -3, 9, 6, 4, -22, -16, -25, -11, 8, -5, 11, 16, 17, 2, 6, 2, 20, 0, -14, 6, -17, 19, 23, -22, -4, -3, -21, 23, -20, 11, 17, 2, 7, -17, 23, 20, -13, -12, -16, 2, 8, 15, -15, -3, -4, 16, 22, -12, -15, 10, -20, -12, 17},
                                                         {3, 10, 2, 11, 2, -18, 6, -20, -24, -17, 21, 2, -16, -17, 8, 3, 10, -11, 7, -10, 9, 22, -7, 9, 0, 7, 5, -1, 16, 13, -6, 6, 4, 9, -22, -2, -4, -16, 10, -20, 3, -4, 6, 6, -12, 19, -14, 7, -11, 9, -1, -4, -3, 22, -18, 6, -9, 17, -15, 20, 2, -19, -12, -12, 13, -11, 23, 0, -21, -16, -19, 1, 4, 2, 11, -13, -10, 12, -4, 5, -5, 22, -16, -19, -12, 23, -16, 6, 1, -3, -18, 3, 24, 14, 2, -3, -17, -7, 17, 23},
                                                         {21, 11, 2, -20, 3, 23, 16, 20, -15, 19, -10, 3, -4, 4, 0, 5, 22, -19, -25, 15, -20, -9, 23, 7, -24, 2, 1, 14, -25, -11, -21, 22, 19, -3, 9, 8, -6, -21, 3, -11, -18, -11, -5, 6, -19, 4, -18, -6, -11, 21, -1, -24, -8, -23, 17, 5, 12, 20, -22, -25, -3, -24, 19, 21, 15, -7, 8, 23, 20, 16, -15, 18, 3, 11, 8, 16, 20, -8, 0, -3, -5, -19, 0, -22, 14, -22, 4, 17, 4, -21, 21, -1, -25, 3, 16, -20, -6, -1, 16, 13},
                                                         {20, -16, -1, -2, 10, 6, -2, 6, -6, -24, 9, -5, -6, 6, 4, -10, 1, 16, -19, 11, 13, 16, -7, 16, 19, 11, 17, 24, 19, 2, -4, -4, 0, 12, 2, -14, 7, -24, -8, -18, 5, 23, -2, 3, -6, 1, -20, -7, 23, 1, 3, 3, -8, -21, 24, -21, 15, 8, 3, 24, 14, -2, 11, 16, 4, -13, 19, 6, -21, -7, 7, -1, -2, 23, -19, 14, -8, 15, -4, -7, 6, -1, -24, -8, 24, 18, -22, -4, 13, -2, -5, 24, -2, -7, -7, -19, -14, 6, 23, -19},
                                                         {6, -2, -11, 4, 19, -22, -21, -6, 22, -16, 11, -25, -14, -15, -7, -11, -3, -6, 17, 11, -16, -2, 18, 6, 22, 8, -24, -20, 5, -25, 3, 11, 17, -11, 11, -18, -16, -4, -2, 20, 14, 9, -2, 3, 11, -5, 12, -12, 24, -22, 9, 17, 14, -14, 22, -17, 4, 8, 7, -15, -23, 24, 14, 22, 6, -25, -17, 21, -2, -15, -20, -25, 20, 21, 22, 0, 24, -10, 19, 2, 20, 13, -20, 1, -10, 10, 21, 5, -8, 2, 2, 1, 14, -12, 18, 14, 20, 0, 21, 11},
                                                         {-13, 15, 14, 13, 23, 8, 22, 17, -11, -3, -17, -11, 14, -21, -11, -12, 19, -12, 6, 21, -22, 2, 4, 20, 8, 3, -14, 7, -22, -18, 4, -1, -7, -18, -11, -20, 24, -9, 2, 7, 12, -21, -10, 20, -7, -13, 12, 9, 23, 4, 20, 7, 18, -25, 8, 9, -14, 18, -20, -6, -4, -10, 13, -19, 17, 9, 21, 6, 15, -16, -11, 2, 10, 24, -17, 24, -13, 9, 1, -5, 16, 2, 8, -1, -13, 22, 5, -8, -2, 4, 18, -20, -15, -18, -15, -3, -10, -17, -23, 9},
                                                         {-9, -20, 18, 13, -11, -7, 21, 19, 16, 9, -3, 1, -9, 10, 3, 19, 6, -11, 19, 19, -21, 3, -18, -14, -10, -16, -9, 3, 13, 11, 8, -22, 6, 17, -21, 11, 8, 20, -16, 18, -24, 10, 0, 14, -18, -8, 13, 0, 3, -9, 15, -24, -12, -18, 4, 12, 22, 7, -2, -20, -24, -7, -20, -20, -25, -7, 20, -1, 5, 17, -15, 11, -21, -25, 18, -7, -22, -7, -22, 23, -5, 15, 24, -4, 20, 7, 15, -2, -12, -9, 13, -24, -4, -22, 17, 7, 5, -5, 13, 13},
                                                         {-4, -11, 20, 11, -19, -21, 21, -13, -11, -15, 9, 4, 3, -1, 9, -14, -7, 9, -16, -7, 3, -4, -15, -11, -21, -16, -11, -24, -17, -15, 13, 7, 4, -10, 1, -19, 20, -13, -10, 16, 11, 2, -16, -23, 7, -16, -3, 22, -6, 6, -12, 21, -15, -5, -15, -25, -22, 5, 7, 21, 14, 20, -21, -22, -3, -24, 24, -12, 23, 3, -10, -19, -7, -7, 6, -25, -13, -17, 6, 20, 11, -8, 7, 2, 22, 17, -3, -16, -21, 1, -22, -11, 5, -7, -24, 16, -2, -20, 4, 5},
                                                         {-16, -17, 24, 15, -10, -18, 2, 17, 13, -15, 13, 19, 24, 12, -15, -3, -13, 1, -19, 4, 4, 15, -16, -3, -1, -24, 0, 24, -9, 15, 2, -19, 3, -25, 10, 3, -7, 16, -14, 14, -11, 4, -5, 18, 12, -17, -10, 18, -17, 4, 3, 21, 24, 24, -24, -7, 24, 2, -9, -11, 7, 2, 1, 23, 8, 6, -9, 23, -24, 6, -22, -4, -10, -8, -10, 24, -5, -10, 9, -9, 10, 7, 16, 11, -13, 5, -19, 3, 24, -8, 4, 16, -1, 22, -18, 11, -22, -3, -15, -20},
                                                         {16, -9, 16, 1, 1, -19, 6, 7, 9, -24, 23, 8, 17, 24, 3, 24, 11, 15, 10, -23, 0, 12, 24, 9, -23, -13, 21, -8, -16, 3, 21, 22, -20, 3, -1, -7, 15, -11, -15, -20, 24, -1, 18, 22, -7, 20, 23, 0, -7, -18, -25, -12, 11, -18, 5, -22, -8, -18, -2, -12, -16, -12, -3, -19, -20, -24, 2, -11, -1, -16, -16, -4, 4, 5, -22, -25, 19, -24, -10, -18, -12, -4, 24, -23, 2, 8, -15, 22, 22, -5, -25, 7, 16, 21, 20, 11, -24, 11, 17, -8}
                                                         })
                                                         .Returns(new PathResults()
                                                         {
                                                             DidWaterFlowThroughEntireGrid = true,
                                                             PathTaken = new List<int>(new int[] { 9, 9, 10, 10, 9, 8, 9, 8, 8, 8, 7, 6, 5, 6, 6, 6, 5, 6, 6, 5, 6, 5, 4, 5, 6, 7, 6, 5, 6, 5, 4, 4, 4, 5, 6, 6, 5, 4, 4, 4, 3, 3, 3, 4, 3, 4, 4, 5, 4, 5, 4, 3, 3, 3, 2, 3, 2, 1, 2, 3, 3, 3, 2, 2, 1, 10, 9, 8, 9, 10, 9, 8, 7, 7, 6, 7, 7, 8, 7, 6, 7, 8, 8, 7, 6, 7, 8, 8, 8, 7, 8, 7, 6, 7, 8, 7, 6, 6, 6, 6 }),
                                                             TotalResistance = -1086
                                                         })
                                                         .SetName("10 x 100 Grid Test Case.");
            }
        }
    }
}