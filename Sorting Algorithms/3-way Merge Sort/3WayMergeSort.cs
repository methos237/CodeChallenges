using System;

/// <summary>
/// Represents a 3-way Merge Sort algorithm implementation.
/// </summary>
public class MergeSort
{
    /// <summary>
    /// Sorts an array of integers using the 3-way Merge Sort algorithm.
    /// </summary>
    /// <param name="arr">The array to be sorted.</param>
    public static void Sort(int[] arr)
    {
        // Check if the array is empty or has only one element
        if (arr.Length <= 1)
        {
            return;
        }

        // Divide the array into three parts
        int n = arr.Length;
        int mid1 = n / 3;
        int mid2 = mid1 * 2;

        // Create temporary arrays to store the three parts
        int[] left = new int[mid1];
        int[] middle = new int[mid2 - mid1];
        int[] right = new int[n - mid2];

        // Copy elements to the temporary arrays
        Array.Copy(arr, 0, left, 0, mid1);
        Array.Copy(arr, mid1, middle, 0, mid2 - mid1);
        Array.Copy(arr, mid2, right, 0, n - mid2);

        // Recursive calls to sort the three parts
        Sort(left);
        Sort(middle);
        Sort(right);

        // Merge the sorted parts
        Merge(arr, left, middle, right);
    }

    private static void Merge(int[] arr, int[] left, int[] middle, int[] right)
    {
        int i = 0, j = 0, k = 0;
        int n1 = left.Length, n2 = middle.Length, n3 = right.Length;

        // Compare and merge elements from the three parts
        while (i < n1 && j < n2 && k < n3)
        {
            if (left[i] <= middle[j] && left[i] <= right[k])
            {
                arr[i + j + k] = left[i];
                i++;
            }
            else if (middle[j] <= left[i] && middle[j] <= right[k])
            {
                arr[i + j + k] = middle[j];
                j++;
            }
            else
            {
                arr[i + j + k] = right[k];
                k++;
            }
        }

        // Merge the remaining elements from left and middle
        while (i < n1 && j < n2)
        {
            if (left[i] <= middle[j])
            {
                arr[i + j + k] = left[i];
                i++;
            }
            else
            {
                arr[i + j + k] = middle[j];
                j++;
            }
        }

        // Merge the remaining elements from left and right
        while (i < n1 && k < n3)
        {
            if (left[i] <= right[k])
            {
                arr[i + j + k] = left[i];
                i++;
            }
            else
            {
                arr[i + j + k] = right[k];
                k++;
            }
        }

        // Merge the remaining elements from middle and right
        while (j < n2 && k < n3)
        {
            if (middle[j] <= right[k])
            {
                arr[i + j + k] = middle[j];
                j++;
            }
            else
            {
                arr[i + j + k] = right[k];
                k++;
            }
        }

        // Copy remaining elements from left
        while (i < n1)
        {
            arr[i + j + k] = left[i];
            i++;
        }

        // Copy remaining elements from middle
        while (j < n2)
        {
            arr[i + j + k] = middle[j];
            j++;
        }

        // Copy remaining elements from right
        while (k < n3)
        {
            arr[i + j + k] = right[k];
            k++;
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

        // Sort the array using 3-way Merge Sort
        MergeSort.Sort(arr);

        // Print the sorted array
        Console.WriteLine("Sorted array: " + string.Join(", ", arr));
    }
}