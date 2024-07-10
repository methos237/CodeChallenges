using System;

class CycleSort
{
    public static void Sort(int[] arr)
    {
        int n = arr.Length;

        for (int cycleStart = 0; cycleStart < n - 1; cycleStart++)
        {
            int item = arr[cycleStart];
            int pos = cycleStart;

            for (int i = cycleStart + 1; i < n; i++)
            {
                if (arr[i] < item)
                {
                    pos++;
                }
            }

            if (pos == cycleStart)
            {
                continue;
            }

            while (item == arr[pos])
            {
                pos++;
            }

            int temp = arr[pos];
            arr[pos] = item;
            item = temp;

            while (pos != cycleStart)
            {
                pos = cycleStart;

                for (int i = cycleStart + 1; i < n; i++)
                {
                    if (arr[i] < item)
                    {
                        pos++;
                    }
                }

                while (item == arr[pos])
                {
                    pos++;
                }

                temp = arr[pos];
                arr[pos] = item;
                item = temp;
            }
        }
    }

    public static void Main()
    {
        int[] arr = { 5, 2, 4, 1, 3 };
        Sort(arr);

        Console.WriteLine("Sorted array:");
        foreach (var num in arr)
        {
            Console.Write(num + " ");
        }
    }
}