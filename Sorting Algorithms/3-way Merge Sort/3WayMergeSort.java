/**
 * Class representing the 3-way Merge Sort algorithm.
 */
class MergeSort {
    /**
     * Method to sort an array using the 3-way Merge Sort algorithm.
     * @param array The array to be sorted.
     */
    public void sort(int[] array) {
        if (array == null || array.length <= 1) {
            return;
        }

        mergeSort(array, 0, array.length - 1);
    }

    /**
     * Recursive helper method to perform the 3-way merge sort on the array.
     * @param array The array to be sorted.
     * @param left The left index of the subarray to be sorted.
     * @param right The right index of the subarray to be sorted.
     */
    private void mergeSort(int[] array, int left, int right) {
        if (left < right) {
            int mid1 = left + (right - left) / 3;
            int mid2 = left + 2 * (right - left) / 3;

            mergeSort(array, left, mid1);
            mergeSort(array, mid1 + 1, mid2);
            mergeSort(array, mid2 + 1, right);

            merge(array, left, mid1, mid2, right);
        }
    }

    /**
     * Method to merge the subarrays after they are sorted.
     * @param array The array to be sorted.
     * @param left The left index of the first subarray.
     * @param mid1 The right index of the first subarray and left index of the second subarray.
     * @param mid2 The right index of the second subarray and left index of the third subarray.
     * @param right The right index of the third subarray.
     */
    private void merge(int[] array, int left, int mid1, int mid2, int right) {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid1 + 1, k = mid2 + 1, index = 0;

        while (i <= mid1 && j <= mid2 && k <= right) {
            if (array[i] <= array[j] && array[i] <= array[k]) {
                temp[index++] = array[i++];
            } else if (array[j] <= array[i] && array[j] <= array[k]) {
                temp[index++] = array[j++];
            } else {
                temp[index++] = array[k++];
            }
        }

        while (i <= mid1 && j <= mid2) {
            if (array[i] <= array[j]) {
                temp[index++] = array[i++];
            } else {
                temp[index++] = array[j++];
            }
        }

        while (i <= mid1 && k <= right) {
            if (array[i] <= array[k]) {
                temp[index++] = array[i++];
            } else {
                temp[index++] = array[k++];
            }
        }

        while (j <= mid2 && k <= right) {
            if (array[j] <= array[k]) {
                temp[index++] = array[j++];
            } else {
                temp[index++] = array[k++];
            }
        }

        while (i <= mid1) {
            temp[index++] = array[i++];
        }

        while (j <= mid2) {
            temp[index++] = array[j++];
        }

        while (k <= right) {
            temp[index++] = array[k++];
        }

        for (int p = 0; p < temp.length; p++) {
            array[left + p] = temp[p];
        }
    }
}

/**
 * Main class to test the 3-way Merge Sort algorithm.
 */
public class Main {
    public static void main(String[] args) {
        int[] array = {64, 34, 25, 12, 22, 11, 90};

        MergeSort mergeSort = new MergeSort();
        mergeSort.sort(array);

        System.out.println("Sorted array:");
        for (int num : array) {
            System.out.print(num + " ");
        }
    }
}