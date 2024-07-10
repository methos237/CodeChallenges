using System;

class CombSort
{
    static int getNextGap(int gap)
    {
        gap = (gap * 10) / 13;
        if (gap < 1)
            return 1;
        return gap;
    }

    static void combSort(int[] arr)
    {
        int n = arr.Length;
        int gap = n;
        bool swapped = true;

        while (gap != 1 || swapped)
        {
            gap = getNextGap(gap);
            swapped = false;

            for (int i = 0; i < n - gap; i++)
            {
                if (arr[i] > arr[i + gap])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + gap];
                    arr[i + gap] = temp;
                    swapped = true;
                }
            }
        }
    }

    static void Main()
    {
        int[] arr = { 8, 4, 1, 9, 3, 5, 2, 7, 6 };
        Console.WriteLine("Array before sorting:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        combSort(arr);

        Console.WriteLine("\nArray after sorting:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
