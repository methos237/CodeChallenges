// Java program to implement Pigeonhole Sort
import java.util.*;

class PigeonholeSort {
    public static void pigeonholeSort(int arr[], int n) {
        int min = arr[0];
        int max = arr[0];
        int range, i, j, index;

        for (int a = 0; a < n; a++) {
            if (arr[a] > max)
                max = arr[a];
            if (arr[a] < min)
                min = arr[a];
        }

        range = max - min + 1;
        int[] phole = new int[range];
        Arrays.fill(phole, 0);

        for (i = 0; i < n; i++)
            phole[arr[i] - min]++;

        index = 0;

        for (j = 0; j < range; j++)
            while (phole[j]-- > 0)
                arr[index++] = j + min;
    }

    public static void main(String[] args) {
        int[] arr = {8, 3, 2, 7, 4, 6, 8};
        int n = arr.length;

        System.out.println("Before sorting:");
        for (int i = 0; i < n; i++)
            System.out.print(arr[i] + " ");

        pigeonholeSort(arr, n);

        System.out.println("\nAfter sorting:");
        for (int i = 0; i < n; i++)
            System.out.print(arr[i] + " ");
    }
}