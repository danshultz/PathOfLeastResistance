using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathOfLeastResistanceLibrary
{
    /// <summary>
    /// Message Payload that is used to return the results of water running over the Grid.
    /// </summary>
    public class PathResults
    {
        public int TotalResistance { get; set; }
        public bool DidWaterFlowThroughEntireGrid { get; set; }
        public List<int> PathTaken { get; set; }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        /// 	<c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="T:System.NullReferenceException">The <paramref name="obj"/> parameter is null.</exception>
        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                return true;
            }
            PathResults resultsToCompare = obj as PathResults;
            return (resultsToCompare != null
                    && resultsToCompare.DidWaterFlowThroughEntireGrid == this.DidWaterFlowThroughEntireGrid
                    && resultsToCompare.TotalResistance == this.TotalResistance
                    && resultsToCompare.PathTaken.SequenceEqual(this.PathTaken));
            

        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            StringBuilder paths = new StringBuilder();
            this.PathTaken.ForEach(i => { paths.Append((paths.Length > 0 ? ", " : "")).Append(i); });

            return new StringBuilder("Total Resistance: ")
                            .Append(this.TotalResistance)
                            .Append("\n Did Water Flow Through Entire Grid: ")
                            .Append(this.DidWaterFlowThroughEntireGrid)
                            .Append("\n Path Taken: ")
                            .Append(paths)
                            .ToString();
        }
    }
}
