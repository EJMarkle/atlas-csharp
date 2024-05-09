using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> new_list = new LinkedList<int>();
        if (size < 0)
        {
            return new_list;
        }
        for (int i = 0; i < size; i++)
        {
            new_list.AddLast(i);
        }
        foreach (int element in new_list)
        {
            Console.WriteLine(element);
        }
        return new_list;
    }
}