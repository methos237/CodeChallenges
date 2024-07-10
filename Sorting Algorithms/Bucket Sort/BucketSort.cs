using System;
using System.Collections.Generic;

class BucketSort
{
    public static void Sort(ref List<float> array)
    {
        if (array == null || array.Count <= 1)
            return;

        int n = array.Count;
        List<float>[] buckets = new List<float>[n];

        for (int i = 0; i < n; i++)
            buckets[i] = new List<float>();

        foreach (float num in array)
        {
            int bucketIndex = (int)(num * n);
            buckets[bucketIndex].Add(num);
        }

        foreach (List<float> bucket in buckets)
            bucket.Sort();

        int index = 0;
        foreach (List<float> bucket in buckets)
        {
            foreach (float num in bucket)
            {
                array[index] = num;
                index++;
            }
        }
    }

    static void Main()
    {
        List<float> array = new List<float> { 0.8f, 0.1f, 0.3f, 0.5f, 0.2f, 0.7f, 0.6f, 0.4f, 0.9f };
        Console.WriteLine("Original Array:");
        PrintArray(array);

        Sort(ref array);

        Console.WriteLine("\nSorted Array:");
        PrintArray(array);
    }

    static void PrintArray(List<float> array)
    {
        foreach (float num in array)
            Console.Write(num + " ");
        Console.WriteLine();
    }
}
