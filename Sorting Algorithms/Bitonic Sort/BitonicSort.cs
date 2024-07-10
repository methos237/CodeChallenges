using System;

class BitonicSort
{
    void BitonicMerge(int[] arr, int low, int count, bool dir)
    {
        if (count > 1)
        {
            int k = count / 2;
            for (int i = low; i < low + k; i++)
                CompareAndSwap(arr, i, i + k, dir);
            BitonicMerge(arr, low, k, dir);
            BitonicMerge(arr, low + k, k, dir);
        }
    }

    void BitonicSortRecursive(int[] arr, int low, int count, bool dir)
    {
        if (count > 1)
        {
            int k = count / 2;
            BitonicSortRecursive(arr, low, k, true);
            BitonicSortRecursive(arr, low + k, k, false);
            BitonicMerge(arr, low, count, dir);
        }
    }

    public void BitonicSort(int[] arr, int count, bool dir)
    {
        BitonicSortRecursive(arr, 0, count, dir);
    }

    void CompareAndSwap(int[] arr, int i, int j, bool dir)
    {
        if ((arr[i] > arr[j] && dir) || (arr[i] < arr[j] && !dir))
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    public static void Main()
    {
        int[] arr = { 3, 7, 4, 8, 6, 2, 1, 5 };
        int count = arr.Length;
        bool dir = true; // true for ascending, false for descending
        BitonicSort bs = new BitonicSort();
        bs.BitonicSort(arr, count, dir);

        Console.WriteLine("Sorted array:");
        for (int i = 0; i < count; i++)
            Console.Write(arr[i] + " ");
    }
}
