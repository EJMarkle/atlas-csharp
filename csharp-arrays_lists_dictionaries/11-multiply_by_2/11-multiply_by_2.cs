using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> new_dict = new Dictionary<string, int>();
        foreach (KeyValuePair<string, int> kvp in myDict)
        {
            new_dict[kvp.Key] = kvp.Value * 2;
        }
        return new_dict;
    }
}