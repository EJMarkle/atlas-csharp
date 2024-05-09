using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] rect = new int[5, 5];
            rect[2, 2] = 1;
            for (int col = 0; col < 5; col++)
            {
                for (int row = 0; row < 5; row++)
                {
                    Console.Write($"{rect[col, row]}");
                    if (row < 4)
                    {
                        Console.Write(" ");    
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}