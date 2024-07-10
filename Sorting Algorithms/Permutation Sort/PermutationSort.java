import java.util.Arrays;

/**
 * This class demonstrates the Permutation Sort algorithm.
 */
public class PermutationSort {

    /**
     * Sorts an array using the Permutation Sort algorithm.
     *
     * @param arr the array to be sorted
     */
    public static void permutationSort(int[] arr) {
        int n = arr.length;
        permutation(arr, 0, n - 1);
    }

    private static void permutation(int[] arr, int start, int end) {
        if (start == end) {
            System.out.println(Arrays.toString(arr));
        } else {
            for (int i = start; i <= end; i++) {
                swap(arr, start, i);
                permutation(arr, start + 1, end);
                swap(arr, start, i);
            }
        }
    }

    private static void swap(int[] arr, int i, int j) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    public static void main(String[] args) {
        int[] arr = {3, 1, 4};
        permutationSort(arr);
    }
}