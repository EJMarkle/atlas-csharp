using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        SortedSet<int> in_both = new SortedSet<int>();
        foreach (int num in list1)
        {
            if (list2.Contains(num))
            {
                in_both.Add(num);
            }
        }
        List<int> common = new List<int>(in_both);
        return common;
    }
}