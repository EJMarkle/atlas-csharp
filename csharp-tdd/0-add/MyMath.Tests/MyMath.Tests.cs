using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class OperationsTests
    {
        [Test]
        public void Add_AddsTwoNumbers_ReturnsSum()
        {
            int a = 5;
            int b = 3;

            int result = Operations.Add(a, b);

            Assert.AreEqual(8, result);
        }
    }
}
