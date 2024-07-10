using System;

/// <summary>
/// Represents a Bubble Sort algorithm implementation.
/// </summary>
public class BubbleSort
{
    /// <summary>
    /// Sorts an array of integers using the Bubble Sort algorithm.
    /// </summary>
    /// <param name="arr">The array to be sorted.</param>
    public static void Sort(int[] arr)
    {
        // Get the length of the array
        int n = arr.Length;

        // Perform n-1 passes
        for (int i = 0; i < n - 1; i++)
        {
            // Flag to check if any swaps were made in this pass
            bool swapped = false;

            // Compare adjacent elements and swap if necessary
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    // Set swapped flag to true
                    swapped = true;
                }
            }

            // If no swaps were made in this pass, the array is already sorted
            if (!swapped)
            {
                break;
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create an array of integers
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        // Print the original array
        Console.WriteLine("Original array: " + string.Join(", ", arr));

        // Sort the array using Bubble Sort
        BubbleSort.Sort(arr);

        // Print the sorted array
        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }
}