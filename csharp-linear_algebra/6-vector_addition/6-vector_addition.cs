using System;

/// <summary>
/// Math
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Adds 2 vectors and returns the resulting vect
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if ((vector1.Length == 2 || vector1.Length == 3) && vector1.Length == vector2.Length)
        {
            double[] sum = new double[vector1.Length];
            for (int i = 0; i < vector1.Length; i++)
            {
                sum[i] = vector1[i] + vector2[i];
            }
            return sum;
        }
        else
        {
            return new double[] { -1 };
        }
    }
}
