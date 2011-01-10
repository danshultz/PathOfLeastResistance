using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathOfLeastResistanceLibrary
{
    public static class LoopExtensionMethods
    {
        public static void Each<T>(this IEnumerable<T> values, Action<T> action)
        {
            foreach (T value in values)
            {
                action(value);
            }
        }

        public static IEnumerable<int> To(this int initialValue, int maxValue)
        {
            for (int i = initialValue; i <= maxValue; i++)
            {
                yield return i;
            }
        }   

    }
}
