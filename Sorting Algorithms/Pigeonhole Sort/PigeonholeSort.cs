using System;

class PigeonholeSort
{
    public static void Sort(int[] arr)
    {
        int min = arr[0];
        int max = arr[0];
        int range, i, j, index;

        for (int a = 0; a < arr.Length; a++)
        {
            if (arr[a] < min)
                min = arr[a];
            if (arr[a] > max)
                max = arr[a];
        }

        range = max - min + 1;
        int[] holes = new int[range];

        for (i = 0; i < arr.Length; i++)
            holes[arr[i] - min]++;

        index = 0;
        for (j = 0; j < range; j++)
            while (holes[j]-- > 0)
                arr[index++] = j + min;
    }

    static void Main()
    {
        int[] arr = { 8, 3, 2, 7, 4, 6, 8 };
        Console.WriteLine("Original array:");
        PrintArray(arr);

        Sort(arr);

        Console.WriteLine("\nSorted array:");
        PrintArray(arr);
    }

    static void PrintArray(int[] arr)
    {
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}