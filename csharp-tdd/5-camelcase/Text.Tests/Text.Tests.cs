using NUnit.Framework;
using Text;

namespace Text.Tests
{
    public class StrTests
    {
        [Test]
        public void CamelCase_CountsWords()
        {
            int result = Str.CamelCase("camelCaseTest");

            Assert.AreEqual(3, result);
        }

        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            int result = Str.CamelCase("");

            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_NullString_ReturnsZero()
        {
            int result = Str.CamelCase(null);

            Assert.AreEqual(0, result);
        }

        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            int result = Str.CamelCase("Single");

            Assert.AreEqual(1, result);
        }
    }
}
