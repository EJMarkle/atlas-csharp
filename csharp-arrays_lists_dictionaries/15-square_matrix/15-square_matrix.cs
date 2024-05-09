using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int rows = myMatrix.GetLength(0);
        int colms = myMatrix.GetLength(1);
        int[,] new_matix = new int[rows, colms];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colms; j++)
            {
                new_matix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }
        return new_matix;
    }
}