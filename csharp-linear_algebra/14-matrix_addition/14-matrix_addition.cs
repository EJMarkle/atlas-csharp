using System;

/// <summary>
/// Math
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Returns the sum of 2 matrices
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if ((matrix1.GetLength(0) == 2 || matrix1.GetLength(0) == 3) && matrix1.GetLength(0) == matrix2.GetLength(0) &&
            matrix1.GetLength(1) == matrix2.GetLength(1))
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            double[,] result = new double[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
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
