/**
 * This method implements the Cocktail Sort algorithm to sort an array of integers.
 * 
 * The algorithm sorts an array of integers by iterating over the array in both directions,
 * swapping elements if they are in the wrong order. The process is repeated until the array is fully sorted.
 *
 * @param arr the array to be sorted
 */
public static void cocktailSort(int[] arr) {
    boolean swapped = true;
    int start = 0;
    int end = arr.length;

    while (swapped) {
        swapped = false;

        for (int i = start; i < end - 1; ++i) {
            if (arr[i] > arr[i + 1]) {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                swapped = true;
            }
        }

        if (!swapped) {
            break;
        }

        swapped = false;
        end--;

        for (int i = end - 1; i >= start; --i) {
            if (arr[i] > arr[i + 1]) {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                swapped = true;
            }
        }

        start++;
    }
}
