using System;

class ShellSort
{
    static void Sort(int[] array)
    {
        int n = array.Length;
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i += 1)
            {
                int temp = array[i];
                int j;
                for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                {
                    array[j] = array[j - gap];
                }
                array[j] = temp;
            }
        }
    }

    static void Main()
    {
        int[] data = { 12, 34, 54, 2, 3 };
        Console.WriteLine("Array before sorting:");
        foreach (int item in data)
        {
            Console.Write(item + " ");
        }

        Sort(data);

        Console.WriteLine("\nArray after sorting:");
        foreach (int item in data)
        {
            Console.Write(item + " ");
        }
    }
}