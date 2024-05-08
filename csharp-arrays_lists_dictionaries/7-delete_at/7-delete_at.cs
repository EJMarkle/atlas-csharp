using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }
        for (int i = index; i < myList.Count - 1; i++)
        {
            myList[i] = myList[i + 1];
        }
        myList.Remove(myList[myList.Count - 1]);
        return myList;
    }
}