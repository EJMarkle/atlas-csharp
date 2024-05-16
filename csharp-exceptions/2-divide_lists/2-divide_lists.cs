using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resultList = new List<int>();

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                int result = 0;
                try
                {
                    if (i >= list1.Count || i >= list2.Count)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    if (list2[i] == 0)
                    {
                        throw new DivideByZeroException();
                    }

                    result = list1[i] / list2[i];
                }
                catch (DivideByZeroException)
                {
                    resultList.Add(0);
                }
                catch (IndexOutOfRangeException)
                {
                    resultList.Add(0);
                }

                if (i >= list1.Count || i >= list2.Count)
                {
                    Console.WriteLine("Out of range");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        return resultList;
    }
}
