using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }
        string high_score = "";
        int currentscore = -1;
        foreach (KeyValuePair<string, int> kvp in myList)
        {
            if (kvp.Value > currentscore)
            {
                currentscore = kvp.Value;
                high_score = kvp.Key;
            }
        }
        return high_score;
    }
}