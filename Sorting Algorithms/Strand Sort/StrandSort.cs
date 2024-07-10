using System;
using System.Collections.Generic;

public class StrandSort
{
    public static List<int> StrandSortAlgorithm(List<int> arr)
    {
        List<int> result = new List<int>();

        while (arr.Count > 0)
        {
            List<int> sublist = new List<int> { arr[0] };
            arr.RemoveAt(0);

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] >= sublist[sublist.Count - 1])
                {
                    sublist.Add(arr[i]);
                    arr.RemoveAt(i);
                    i--;
                }
            }

            result = Merge(result, sublist);
        }

        return result;
    }

    private static List<int> Merge(List<int> list1, List<int> list2)
    {
        List<int> merged = new List<int>();
        int i = 0, j = 0;

        while (i < list1.Count && j < list2.Count)
        {
            if (list1[i] < list2[j])
            {
                merged.Add(list1[i]);
                i++;
            }
            else
            {
                merged.Add(list2[j]);
                j++;
            }
        }

        while (i < list1.Count)
        {
            merged.Add(list1[i]);
            i++;
        }

        while (j < list2.Count)
        {
            merged.Add(list2[j]);
            j++;
        }

        return merged;
    }

    public static void Main()
    {
        List<int> arr = new List<int> { 12, 11, 13, 5, 6 };
        List<int> sortedArr = StrandSortAlgorithm(arr);

        Console.WriteLine("Sorted Array:");
        foreach (int num in sortedArr)
        {
            Console.Write(num + " ");
        }
    }
}