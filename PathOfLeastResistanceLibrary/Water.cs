using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathOfLeastResistanceLibrary
{
    public class Water
    {
        /// <summary>
        /// Flows the specified path one.
        /// </summary>
        /// <param name="pathOne">The path one.</param>
        /// <param name="pathTwo">The path two.</param>
        /// <param name="pathThree">The path three.</param>
        /// <returns></returns>
        public int Flow(int pathOne, int pathTwo, int pathThree)
        {
            return this.Flow(new int[]{ pathOne, pathTwo, pathThree });
        }

        /// <summary>
        /// Flows the specified path options.
        /// </summary>
        /// <param name="pathOptions">The path options.</param>
        /// <returns></returns>
        /// <exception cref="ResistanceTooHighException">Throws when resistance met reaches or exceeds 50</exception>
        public int Flow(int[] pathOptions)
        {
            int selectedValue = pathOptions.Min();
            if (this.TotalResistance + selectedValue >= 50)
            {
                throw new ResistanceTooHighException("Total Resistance Met is " + this.TotalResistance + selectedValue);
            }
            this.TotalResistance += selectedValue;
            return selectedValue;
        }

        /// <summary>
        /// Gets or sets the total resistance.
        /// </summary>
        /// <value>The total resistance.</value>
        public int TotalResistance { get; private set; }
    }
}
