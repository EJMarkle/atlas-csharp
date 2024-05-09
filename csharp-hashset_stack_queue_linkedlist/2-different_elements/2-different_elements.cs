using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        SortedSet<int> not_both = new SortedSet<int>();
        foreach (int num in list1)
        {
            if (!list2.Contains(num))
            {
                not_both.Add(num);
            }
        }
        foreach (int num in list2)
        {
            if (!list1.Contains(num))
            {
                not_both.Add(num);
            }
        }
        List<int> different = new List<int>(not_both);
        return different;
    }
}