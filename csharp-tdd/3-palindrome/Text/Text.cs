using System;
using System.Linq;

namespace Text
{
        /// <summary>
        /// Text operations
        /// </summary>
    public class Str
    {
        /// <summary>
        /// Checks if a string is a palindrome.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if string is a palindrome, False if it's not.</returns>
        public static bool IsPalindrome(string s)
        {
            string cleanString = new string(s.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());
            for (int i = 0; i < cleanString.Length / 2; i++)
            {
                if (cleanString[i] != cleanString[cleanString.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
