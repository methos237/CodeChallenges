// Java program for Bitonic Sort. Note that this program works only when size of input is a power of 2.

import java.util.*;

public class BitonicSort {
    /* The parameter dir indicates the sorting direction, ASCENDING
       or DESCENDING; if (a[i] > a[j]) agrees with the direction,
       then a[i] and a[j] are interchanged. */
    void compAndSwap(int a[], int i, int j, int dir) {
        if ((a[i] > a[j] && dir == 1) || (a[i] < a[j] && dir == 0)) {
            // Swapping elements
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }

    /* Recursively sorts a bitonic sequence in ascending order, if dir = 1,
       and in descending order otherwise (means dir=0). The sequence to be sorted
       starts at index position low, the parameter cnt is the number of elements to be sorted. */
    void bitonicMerge(int a[], int low, int cnt, int dir) {
        if (cnt > 1) {
            int k = cnt / 2;
            for (int i = low; i < low + k; i++)
                compAndSwap(a, i, i + k, dir);
            bitonicMerge(a, low, k, dir);
            bitonicMerge(a, low + k, k, dir);
        }
    }

    /* This function first produces a bitonic sequence by recursively sorting
       its two halves in opposite sorting orders, and then calls bitonicMerge
       to make them in the same order */
    void bitonicSort(int a[], int low, int cnt, int dir) {
        if (cnt > 1) {
            int k = cnt / 2;
            bitonicSort(a, low, k, 1);
            bitonicSort(a, low + k, k, 0);
            bitonicMerge(a, low, cnt, dir);
        }
    }

    /* A utility function to print array of size n */
    void printArray(int a[]) {
        int n = a.length;
        for (int i = 0; i < n; i++)
            System.out.print(a[i] + " ");
        System.out.println();
    }

    public static void main(String args[]) {
        int a[] = {3, 7, 4, 8, 6, 2, 1, 5};
        int n = a.length;
        int dir = 1; // 1 represents ascending order, 0 represents descending order

        BitonicSort ob = new BitonicSort();
        ob.bitonicSort(a, 0, n, dir);

        System.out.println("Sorted array: ");
        ob.printArray(a);
    }
}
