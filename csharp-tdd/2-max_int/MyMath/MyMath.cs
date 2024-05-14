using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>
    /// Math operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Finds the maximum integer in a list of integers.
        /// </summary>
        /// <param name="nums">The list of integers.</param>
        /// <returns>The maximum integer in the list.</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }

            return nums.Max();
        }
    }
}
