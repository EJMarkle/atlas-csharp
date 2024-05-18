using System;

/// <summary>
/// Math
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates dot product of two vectors
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if ((vector1.Length == 2 || vector1.Length == 3) && vector1.Length == vector2.Length)
        {
            double dotProduct = 0;
            for (int i = 0; i < vector1.Length; i++)
            {
                dotProduct += vector1[i] * vector2[i];
            }
            return dotProduct;
        }
        else
        {
            return -1;
        }
    }
}
