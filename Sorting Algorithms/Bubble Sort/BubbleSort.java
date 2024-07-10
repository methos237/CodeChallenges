/**
 * Class representing the Bubble Sort algorithm.
 */
class BubbleSort {
    /**
     * Method to sort an array using the Bubble Sort algorithm.
     * @param array The array to be sorted.
     */
    public void sort(int[] array) {
        int n = array.length;

        // Perform n-1 passes through the array
        for (int i = 0; i < n - 1; i++) {
            // Compare adjacent elements and swap them if they are in the wrong order
            for (int j = 0; j < n - i - 1; j++) {
                if (array[j] > array[j + 1]) {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}

/**
 * Main class to test the Bubble Sort algorithm.
 */
public class Main {
    public static void main(String[] args) {
        int[] array = {64, 34, 25, 12, 22, 11, 90};

        BubbleSort bubbleSort = new BubbleSort();
        bubbleSort.sort(array);

        System.out.println("Sorted array:");
        for (int num : array) {
            System.out.print(num + " ");
        }
    }
}