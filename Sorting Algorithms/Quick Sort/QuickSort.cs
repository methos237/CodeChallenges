using System;

class QuickSort
{
    public static void Sort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(array, low, high);

            Sort(array, low, partitionIndex - 1);
            Sort(array, partitionIndex + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

        int temp1 = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp1;

        return i + 1;
    }

    public static void PrintArray(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; ++i)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        int n = array.Length;

        Console.WriteLine("Original array:");
        PrintArray(array);

        Sort(array, 0, n - 1);

        Console.WriteLine("Sorted array:");
        PrintArray(array);
    }
}