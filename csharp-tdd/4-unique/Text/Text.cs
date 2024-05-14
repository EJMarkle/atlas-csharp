using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Text operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character in a string.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>The index of the first non-repeating character, or -1 if none.</returns>
        public static int UniqueChar(string s)
        {
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (charCounts.ContainsKey(c))
                {
                    charCounts[c]++;
                }
                else
                {
                    charCounts[c] = 1;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (charCounts[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
