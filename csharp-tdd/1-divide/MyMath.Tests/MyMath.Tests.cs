using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    public class MatrixTests
    {
        [Test]
        public void Divide_DividesAllElements_ReturnsNewMatrix()
        {
            // Arrange
            int[,] inputMatrix = { { 10, 20 }, { 30, 40 } };
            int num = 2;
            int[,] expectedMatrix = { { 5, 10 }, { 15, 20 } };

            // Act
            int[,] result = Matrix.Divide(inputMatrix, num);

            // Assert
            Assert.AreEqual(expectedMatrix, result);
        }

        [Test]
        public void Divide_ByZero_ReturnsNull()
        {
            // Arrange
            int[,] inputMatrix = { { 10, 20 }, { 30, 40 } };
            int num = 0;

            // Act
            int[,] result = Matrix.Divide(inputMatrix, num);

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            // Arrange
            int[,] inputMatrix = null;
            int num = 2;

            // Act
            int[,] result = Matrix.Divide(inputMatrix, num);

            // Assert
            Assert.IsNull(result);
        }
    }
}
