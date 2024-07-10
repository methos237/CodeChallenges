using System;

class MergeSort
{
    public static void Sort(int[] array)
    {
        if (array.Length <= 1)
            return;

        int mid = array.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);

        Sort(left);
        Sort(right);
        Merge(left, right, array);
    }

    private static void Merge(int[] left, int[] right, int[] result)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                result[k] = left[i];
                i++;
            }
            else
            {
                result[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < left.Length)
        {
            result[k] = left[i];
            i++;
            k++;
        }

        while (j < right.Length)
        {
            result[k] = right[j];
            j++;
            k++;
        }
    }

    static void Main()
    {
        int[] array = { 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Original array:");
        PrintArray(array);

        Sort(array);

        Console.WriteLine("\nSorted array:");
        PrintArray(array);
    }

    private static void PrintArray(int[] array)
    {
        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}