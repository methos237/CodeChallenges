using System;

class TimSort
{
    static int MIN_MERGE = 32;

    public static void Sort(int[] arr, int n)
    {
        for (int i = 0; i < n; i += MIN_MERGE)
        {
            Array.Sort(arr, i, Math.Min((i + MIN_MERGE - 1), (n - 1)));
        }

        for (int size = MIN_MERGE; size < n; size = 2 * size)
        {
            for (int left = 0; left < n; left += 2 * size)
            {
                int mid = left + size - 1;
                int right = Math.Min((left + 2 * size - 1), (n - 1));

                Merge(arr, left, mid, right);
            }
        }
    }

    static void Merge(int[] arr, int l, int m, int r)
    {
        int len1 = m - l + 1;
        int len2 = r - m;

        int[] left = new int[len1];
        int[] right = new int[len2];

        Array.Copy(arr, l, left, 0, len1);
        Array.Copy(arr, m + 1, right, 0, len2);

        int i = 0, j = 0, k = l;

        while (i < len1 && j < len2)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < len1)
        {
            arr[k] = left[i];
            i++;
            k++;
        }

        while (j < len2)
        {
            arr[k] = right[j];
            j++;
            k++;
        }
    }

    public static void Main()
    {
        int[] arr = { 5, 2, 9, 1, 5, 6, 3 };
        int n = arr.Length;

        Console.WriteLine("Array before sorting:");
        PrintArray(arr);

        Sort(arr, n);

        Console.WriteLine("\nArray after sorting:");
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