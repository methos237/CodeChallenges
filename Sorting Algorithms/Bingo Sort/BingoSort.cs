using System;

class BingoSort
{
    static void Main()
    {
        int[] array = { 12, 4, 7, 1, 9, 3, 5, 6, 8, 2, 10, 11 };
        int n = array.Length;

        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);

        Console.WriteLine("Sorted Array:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
