/**
 * This class implements the Bingo Sort algorithm.
 */
public class BingoSort {

    /**
     * Sorts an array using the Bingo Sort algorithm.
     *
     * @param arr The array to be sorted.
     */
    public static void bingoSort(int[] arr) {
        int n = arr.length;
        boolean swapped;
        do {
            swapped = false;
            for (int i = 0; i < n - 1; i++) {
                if (arr[i] > arr[i + 1]) {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }

    /**
     * Main method to test the Bingo Sort algorithm.
     *
     * @param args Command line arguments (not used).
     */
    public static void main(String[] args) {
        int[] arr = {64, 34, 25, 12, 22, 11, 90};
        System.out.println("Array before sorting:");
        for (int num : arr) {
            System.out.print(num + " ");
        }
        System.out.println();
        
        bingoSort(arr);

        System.out.println("Array after sorting:");
        for (int num : arr) {
            System.out.print(num + " ");
        }
    }
}
