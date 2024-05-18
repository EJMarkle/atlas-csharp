using System;

/// <summary>
/// Math
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if ((matrix.GetLength(0) == 2 || matrix.GetLength(0) == 3) && (matrix.GetLength(1) == 2 || matrix.GetLength(1) == 3))
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            double[,] result = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }
        else
        {
            return new double[,] { { -1 } };
        }
    }
}
