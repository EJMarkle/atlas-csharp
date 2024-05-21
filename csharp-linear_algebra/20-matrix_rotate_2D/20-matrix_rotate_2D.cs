using System;

/// <summary>
/// Math
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotate matrix!
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int n = matrix.GetLength(0);
        if (matrix.GetLength(1) != n)
        {
            return new double[,] { { -1 } };
        }

        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        double[,] rotationMatrix = new double[,]
        {
            { cosTheta, -sinTheta },
            { sinTheta, cosTheta }
        };

        double[,] result = new double[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                double x = i * cosTheta - j * sinTheta;
                double y = i * sinTheta + j * cosTheta;

                result[i, j] = matrix[i, j] * rotationMatrix[0, 0] + matrix[i, j] * rotationMatrix[1, 1];
            }
        }

        return result;
    }
}
