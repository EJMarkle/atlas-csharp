using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        ICollection<string> keys = myDict.Keys;
        List<string> SortedKeys = new List<string>(keys);
        SortedKeys.Sort();
        foreach (string key in SortedKeys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}