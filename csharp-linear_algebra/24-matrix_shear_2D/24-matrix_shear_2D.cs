using System;

/// <summary>
/// Matrix Math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Matrix shearer
    /// </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2)
        {
            return new double[,] { { -1 } };
        }

        if (direction != 'x' && direction != 'y')
        {
            return new double[,] { { -1 } };
        }

        double[,] shearMatrix = new double[2, 2];

        if (direction == 'x')
        {
            shearMatrix[0, 0] = 1;
            shearMatrix[0, 1] = factor;
            shearMatrix[1, 0] = 0;
            shearMatrix[1, 1] = 1;
        }
        else if (direction == 'y')
        {
            shearMatrix[0, 0] = 1;
            shearMatrix[0, 1] = 0;
            shearMatrix[1, 0] = factor;
            shearMatrix[1, 1] = 1;
        }

        double[,] resultMatrix = MultiplyMatrix(matrix, shearMatrix);

        return resultMatrix;
    }

    /// <summary>
    /// Mult matrices
    /// </summary>
    private static double[,] MultiplyMatrix(double[,] matrix1, double[,] matrix2)
    {
        double[,] resultMatrix = new double[2, 2];

        resultMatrix[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0];
        resultMatrix[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
        resultMatrix[1, 0] = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
        resultMatrix[1, 1] = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];

        return resultMatrix;
    }
}
