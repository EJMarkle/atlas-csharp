using System;

/// <summary>
/// Math
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2 || vector.Length == 3)
        {
            double[] result = new double[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                result[i] = vector[i] * scalar;
            }
            return result;
        }
        else
        {
            return new double[] { -1 };
        }
    }
}
