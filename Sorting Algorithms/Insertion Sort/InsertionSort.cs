using System;

class InsertionSort
{
    static void Sort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] array = { 12, 11, 13, 5, 6 };
        Console.WriteLine("Array before sorting:");
        PrintArray(array);

        Sort(array);

        Console.WriteLine("\nArray after sorting:");
        PrintArray(array);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}