using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> used_ints = new HashSet<int>();
        int sum = 0;
        foreach (int num in myList)
        {
            if (!used_ints.Contains(num))
            {
                sum += num;
                used_ints.Add(num);
            }
        }
        return sum;
    }
}