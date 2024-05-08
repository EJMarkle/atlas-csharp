using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> new_list = new List<int>();
        for (int i = 0; i < size; i++)
        {
            new_list.Add(i);
        }
        for (int j = 0; j < size; j++)
        {
            Console.Write(new_list[j]);
            if (j == size - 1)
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
        return new_list;
    }
}