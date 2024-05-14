using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void IsPalindrome_Racecar_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("Racecar");

            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_Level_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("level");

            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_PalindromeWithPunctuation_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("A man, a plan, a canal: Panama.");

            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            bool result = Str.IsPalindrome("hello");

            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            bool result = Str.IsPalindrome("");
            Assert.IsTrue(result);
        }
    }
}
