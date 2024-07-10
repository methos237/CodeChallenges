using System;

class CountingSort
{
    public static void Sort(int[] array, int maxValue)
    {
        int[] counts = new int[maxValue + 1];
        int[] sortedArray = new int[array.Length];

        foreach (int num in array)
        {
            counts[num]++;
        }

        for (int i = 1; i < counts.Length; i++)
        {
            counts[i] += counts[i - 1];
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            sortedArray[counts[array[i]] - 1] = array[i];
            counts[array[i]]--;
        }

        Array.Copy(sortedArray, array, array.Length);
    }

    static void Main()
    {
        int[] array = { 4, 2, 2, 8, 3, 3, 1 };
        int maxValue = 8;

        Console.WriteLine("Original array:");
        PrintArray(array);

        Sort(array, maxValue);

        Console.WriteLine("\nSorted array:");
        PrintArray(array);
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}