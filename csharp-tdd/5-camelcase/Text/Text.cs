namespace Text
{
    /// <summary>
    /// Text operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines the number of words in a string.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>The number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            int wordCount = 1;

            foreach (char c in s.Substring(1))
            {
                if (char.IsUpper(c))
                {
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}
