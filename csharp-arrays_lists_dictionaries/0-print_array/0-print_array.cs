using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] new_array = new int[size];
        for (int i = 0; i < size; i++)
        {
            new_array[i] = i;
        }
        foreach (int num in new_array)
        {
            Console.Write(num);
            if (num == size - 1)
            {
                Console.WriteLine();
            }
            else
            {
                Console.Write(" ");
            }
        }
        if (size == 0)
        {
            Console.WriteLine();
        }
        return new_array;
    }
}