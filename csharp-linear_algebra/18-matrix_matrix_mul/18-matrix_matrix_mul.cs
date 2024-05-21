using System;

/// <summary>
/// Math
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Mult 2 matrices
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int m1Rows = matrix1.GetLength(0);
        int m1Cols = matrix1.GetLength(1);
        int m2Rows = matrix2.GetLength(0);
        int m2Cols = matrix2.GetLength(1);

        if (m1Cols != m2Rows)
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[m1Rows, m2Cols];

        for (int i = 0; i < m1Rows; i++)
        {
            for (int j = 0; j < m2Cols; j++)
            {
                double sum = 0;
                for (int k = 0; k < m1Cols; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }
}
