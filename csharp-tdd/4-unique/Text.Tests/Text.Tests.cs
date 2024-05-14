using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void UniqueChar_FirstNonRepeating_ReturnsIndex()
        {
            int result = Str.UniqueChar("leetcode");

            Assert.AreEqual(0, result);
        }

        [Test]
        public void UniqueChar_AllRepeating_ReturnsNegativeOne()
        {
            int result = Str.UniqueChar("hello");

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnsNegativeOne()
        {
            int result = Str.UniqueChar("");

            Assert.AreEqual(-1, result);
        }
    }
}
