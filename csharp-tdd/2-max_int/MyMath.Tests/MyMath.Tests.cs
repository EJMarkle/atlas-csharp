using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void Max_ReturnsMaxInteger()
        {
            List<int> nums = new List<int> { 1, 5, 3, 8, 2 };

            int max = Operations.Max(nums);

            Assert.AreEqual(8, max);
        }

        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            List<int> nums = new List<int>();

            int max = Operations.Max(nums);

            Assert.AreEqual(0, max);
        }

        [Test]
        public void Max_NullList_ReturnsZero()
        {
            List<int> nums = null;

            int max = Operations.Max(nums);

            Assert.AreEqual(0, max);
        }
    }
}
