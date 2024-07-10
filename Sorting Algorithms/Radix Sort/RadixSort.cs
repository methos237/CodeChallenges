using System;

class RadixSort
{
    public static void Radix_Sort(int[] arr)
    {
        int i, j;
        int[] tmp = new int[arr.Length];
        int[] count = new int[256];

        for (int shift = 0; shift < 32; shift += 8)
        {
            count = new int[256];
            int mask = 255 << shift;

            foreach (int num in arr)
            {
                count[(num & mask) >> shift]++;
            }

            for (i = 1; i < 256; i++)
            {
                count[i] += count[i - 1];
            }

            for (j = arr.Length - 1; j >= 0; j--)
            {
                tmp[--count[(arr[j] & mask) >> shift]] = arr[j];
            }

            tmp.CopyTo(arr, 0);
        }
    }

    static void Main()
    {
        int[] arr = { 170, 45, 75, 90, 802, 24, 2, 66 };
        Radix_Sort(arr);

        Console.WriteLine("Sorted array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}