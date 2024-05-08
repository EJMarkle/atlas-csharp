using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> mod2 = new List<bool>();
        foreach (int num in myList)
        {
            if (num % 2 == 0)
            {
                mod2.Add(true);
            }
            else
            {
                mod2.Add(false);
            }
        }
        return mod2;
    }
}