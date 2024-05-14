using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Test]
        public void Divide_DividesAllElements_ReturnsNewMatrix()
        {
            int[,] inputMatrix = { { 10, 20 }, { 30, 40 } };
            int num = 2;
            int[,] expectedMatrix = { { 5, 10 }, { 15, 20 } };

            int[,] result = Matrix.Divide(inputMatrix, num);

            Assert.AreEqual(expectedMatrix, result);
        }

        [Test]
        public void Divide_ByZero_ReturnsNull()
        {
            int[,] inputMatrix = { { 10, 20 }, { 30, 40 } };
            int num = 0;

            int[,] result = Matrix.Divide(inputMatrix, num);

            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            int[,] inputMatrix = null;
            int num = 2;

            int[,] result = Matrix.Divide(inputMatrix, num);

            Assert.IsNull(result);
        }
    }
}
