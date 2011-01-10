using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace PathOfLeastResistanceLibrary
{
    /// <summary>
    /// The Grid defines the layout which Water can Flow
    /// </summary>
    public class Grid
    {
        private readonly int[][] _grid = null;
        private readonly int[,] _originalGrid = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid"/> class.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public Grid(int[,] grid)
        {
            if (grid == null)
            {
                throw new ArgumentNullException();
            }
            this._grid = this.ConvertTwoDimensionArrayToJaggedArray(grid);
            this._originalGrid = grid;
        }


        /// <summary>
        /// Converts the two dimension array to jagged array as this is easier to deal with.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <returns></returns>
        private int[][] ConvertTwoDimensionArrayToJaggedArray(int[,] grid)
        {
            this.Width = grid.GetLength(1);
            this.Height = grid.GetLength(0);

            int[][] jaggedArray = new int[this.Width][];
            for (int x = 0; x < this.Width; x++)
            {
                int[] column = new int[this.Height];
                for (int y = 0; y < this.Height; y++)
                {
                    column[y] = grid[y, x];
                }
                jaggedArray[x] = column;
            }
            return jaggedArray;
        }

        /// <summary>
        /// Finds the path of least resistance.
        /// </summary>
        /// <param name="water">The water.</param>
        /// <returns></returns>
        public PathResults FindPathOfLeastResistance(Water water)
        {
            List<int> pathsTaken = new List<int>();
            bool didWaterFlowThroughEntireGrid = true;
            int lastPathTakenIndex = -1;

            try
            {
                foreach (int[] paths in _grid)
                {
                    int[] pathOptions = this.GetPathOptions(paths, lastPathTakenIndex);

                    int valueChosen = water.Flow(pathOptions);

                    int pathOptionChosenIndex = Array.IndexOf<int>(pathOptions, valueChosen);
                    lastPathTakenIndex = this.GetIndexOfValueChosen(pathOptionChosenIndex, lastPathTakenIndex, paths.Length);
                    pathsTaken.Add(lastPathTakenIndex + 1); //Add one to the Path because the path taken is 1 based
                }
            }
            catch (ResistanceTooHighException rthe)
            {
                didWaterFlowThroughEntireGrid = false;
            }

            return new PathResults() { PathTaken = pathsTaken, DidWaterFlowThroughEntireGrid = didWaterFlowThroughEntireGrid, TotalResistance = water.TotalResistance };
        }

        /// <summary>
        /// Gets the index of value chosen.
        /// </summary>
        /// <param name="pathOptionChosenIndex">Index of the path option chosen.</param>
        /// <param name="lastPathTakenIndex">Last index of the path taken.</param>
        /// <param name="pathsLength">Length of the paths.</param>
        /// <returns></returns>
        private int GetIndexOfValueChosen(int pathOptionChosenIndex, int lastPathTakenIndex, int pathsLength)
        {
            int value = lastPathTakenIndex;
            
            /// If the last path taken is -1, then this is the first index option 
            /// so return the actual path that is chosen (all paths were options)
            if (lastPathTakenIndex < 0)
            {
                value = pathOptionChosenIndex;
            }
            else if (pathOptionChosenIndex == 0)
            {
                value = lastPathTakenIndex - 1 < 0 ? pathsLength - 1 : lastPathTakenIndex - 1;
            }
            else if (pathOptionChosenIndex == 2)
            {
                value = lastPathTakenIndex + 1 == pathsLength ? 0 : lastPathTakenIndex + 1;
            }

            //Else lastPathTakenIndex
            return value;
        }

        /// <summary>
        /// Gets the path options.
        /// </summary>
        /// <param name="paths">The paths.</param>
        /// <param name="lastPathTakenIndex">Last index of the path taken.</param>
        /// <returns></returns>
        private int[] GetPathOptions(int[] paths, int lastPathTakenIndex)
        {
            //If the last path is -1, return all paths as options
            if (lastPathTakenIndex < 0)
            {
                return paths;
            }

            int[] pathOptions = new int[3];
            pathOptions[0] = paths[(lastPathTakenIndex - 1 < 0 ? paths.Length - 1 : lastPathTakenIndex - 1)];
            pathOptions[1] = paths[lastPathTakenIndex];
            pathOptions[2] = paths[(lastPathTakenIndex + 1 == paths.Length ? 0 : lastPathTakenIndex + 1)];
            return pathOptions;
        }
        public int Width { get; private set; }
        public int Height { get; private set; }

        public System.Data.DataSet ToDataSet()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = dataSet.Tables.Add();
            1.To(this.Width).Each(i => 
            { 
                dataTable.Columns.Add("Column" + i, typeof(Int32)); 
            });
            0.To(this.Height - 1).Each(x =>
            {
                DataRow row = dataTable.NewRow();
                0.To(this.Width - 1).Each(y => { row[y] = this._originalGrid[x, y]; });
                dataTable.Rows.Add(row);
            });

            return dataSet;
        }
    }
}
