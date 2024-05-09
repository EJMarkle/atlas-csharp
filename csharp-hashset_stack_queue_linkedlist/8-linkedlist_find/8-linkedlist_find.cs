using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int index_found = -1;
        int current_index = -1;
        foreach (int element in myLList)
        {
            current_index++;
            if (element == value)
            {
                index_found = current_index;
                return index_found;
            }
        }
        return index_found;
    }      
}