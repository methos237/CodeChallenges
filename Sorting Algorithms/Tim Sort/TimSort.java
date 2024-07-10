import java.util.Arrays;

public class TimSort {

    static int MIN_MERGE = 32;

    public static void timSort(int[] arr, int n) {
        for (int i = 0; i < n; i += MIN_MERGE) {
            Arrays.sort(arr, i, Math.min((i + MIN_MERGE), (n - 1)));
        }

        for (int size = MIN_MERGE; size < n; size = 2 * size) {
            for (int left = 0; left < n; left += 2 * size) {
                int mid = left + size - 1;
                int right = Math.min((left + 2 * size - 1), (n - 1));
                merge(arr, left, mid, right);
            }
        }
    }

    public static void merge(int[] arr, int l, int m, int r) {
        int len1 = m - l + 1;
        int len2 = r - m;

        int[] left = new int[len1];
        int[] right = new int[len2];

        for (int i = 0; i < len1; i++) {
            left[i] = arr[l + i];
        }
        for (int j = 0; j < len2; j++) {
            right[j] = arr[m + 1 + j];
        }

        int i = 0, j = 0;
        int k = l;

        while (i < len1 && j < len2) {
            if (left[i] <= right[j]) {
                arr[k] = left[i];
                i++;
            } else {
                arr[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < len1) {
            arr[k] = left[i];
            i++;
            k++;
        }

        while (j < len2) {
            arr[k] = right[j];
            j++;
            k++;
        }
    }

    public static void main(String[] args) {
        int[] arr = {5, 2, 9, 1, 5, 6, 0, 3};
        int n = arr.length;
        System.out.println("Array before sorting: " + Arrays.toString(arr));
        timSort(arr, n);
        System.out.println("Array after sorting: " + Arrays.toString(arr));
    }
}