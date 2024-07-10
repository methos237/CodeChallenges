/**
 * This class implements the Brick Sort algorithm to sort an array of integers in ascending order.
 */
public class BrickSort {

    /**
     * Sorts the input array using the Brick Sort algorithm.
     *
     * @param arr The array to be sorted
     */
    public static void brickSort(int[] arr) {
        boolean sorted = false;
        while (!sorted) {
            sorted = true;
            for (int i = 1; i <= arr.length - 2; i += 2) {
                if (arr[i] > arr[i + 1]) {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    sorted = false;
                }
            }
            for (int i = 0; i <= arr.length - 2; i += 2) {
                if (arr[i] > arr[i + 1]) {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    sorted = false;
                }
            }
        }
    }

    /**
     * A utility method to print the elements of an array.
     *
     * @param arr The array to be printed
     */
    public static void printArray(int[] arr) {
        for (int num : arr) {
            System.out.print(num + " ");
        }
        System.out.println();
    }

    public static void main(String[] args) {
        int[] array = {64, 34, 25, 12, 22, 11, 90};
        System.out.println("Original array:");
        printArray(array);

        brickSort(array);

        System.out.println("Sorted array:");
        printArray(array);
    }
}
