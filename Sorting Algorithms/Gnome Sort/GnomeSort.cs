using System;

class GnomeSort
{
    static void Gnome_Sort(int[] arr, int n)
    {
        int index = 0;

        while (index < n)
        {
            if (index == 0)
                index++;
            if (arr[index] >= arr[index - 1])
                index++;
            else
            {
                int temp = 0;
                temp = arr[index];
                arr[index] = arr[index - 1];
                arr[index - 1] = temp;
                index--;
            }
        }
    }

    static void Main()
    {
        int[] arr = { 34, 2, 10, -9, 20 };
        int n = arr.Length;

        Console.WriteLine("Original array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Gnome_Sort(arr, n);

        Console.WriteLine("\nSorted array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}