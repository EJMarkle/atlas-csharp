using System;

/// <summary>
/// Matrix Math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Rotate matrix by degree
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != 2 || cols != 2 )
        {
            return new double[,] { { -1 } };
        }

        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        double a = matrix[0, 0];
        double b = matrix[0, 1];
        double c = matrix[1, 0];
        double d = matrix[1, 1];

        double aNew = Math.Round((cosTheta * a - sinTheta * b), 2);
        double bNew = Math.Round((sinTheta * a + cosTheta * b), 2);
        double cNew = Math.Round((cosTheta * c - sinTheta * d), 2);
        double dNew = Math.Round((sinTheta * c + cosTheta * d), 2);

        return new double[,] { { aNew, bNew }, { cNew, dNew } };
    }
}