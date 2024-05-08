using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length <= 0)
        {
            Console.WriteLine();
            return;
        }
        for (int i = array.Length - 1; i > -1; i--)
        {
            Console.Write(array[i]);
            if (i == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
}