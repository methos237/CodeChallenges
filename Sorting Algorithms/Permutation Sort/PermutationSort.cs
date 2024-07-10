using System;
using System.Collections.Generic;

/// <summary>
/// Class to demonstrate Permutation Sort algorithm.
/// </summary>
public class PermutationSort
{
    /// <summary>
    /// Sorts an array using Permutation Sort algorithm.
    /// </summary>
    /// <param name="arr">The array to be sorted.</param>
    public void Sort(int[] arr)
    {
        Permute(arr, 0, arr.Length - 1);
    }

    private void Permute(int[] arr, int startIndex, int endIndex)
    {
        if (startIndex == endIndex)
        {
            // Process the permutation (e.g., check if it's sorted)
        }
        else
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                Swap(ref arr[startIndex], ref arr[i]);
                Permute(arr, startIndex + 1, endIndex);
                Swap(ref arr[startIndex], ref arr[i]); // Backtrack
            }
        }
    }

    private void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

// Usage example:
int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };
PermutationSort sorter = new PermutationSort();
sorter.Sort(array);