using System;

/// <summary> 
/// Math
/// </summary>
namespace VectorMath
{
    /// <summary>
    /// Gets magnitude of 2d and 3d vectors
    /// </summary>
    public class VectorMath
    {
        public static double Magnitude(double[] vector)
        {
            if (vector.Length == 2)
            {
                double magnitude = Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1]);
                return Math.Round(magnitude, 2);
            }
            else if (vector.Length == 3)
            {
                double magnitude = Math.Sqrt(vector[0] * vector[0] + vector[1] * vector[1] + vector[2] * vector[2]);
                return Math.Round(magnitude, 2);
            }
            else
            {
                return -1;
            }
        }
    }
}
