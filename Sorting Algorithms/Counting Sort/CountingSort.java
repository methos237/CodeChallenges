public class CountingSort {
    public static void countingSort(int[] array, int max) {
        int[] count = new int[max + 1];
        int[] output = new int[array.length];

        for (int value : array) {
            count[value]++;
        }

        for (int i = 1; i <= max; i++) {
            count[i] += count[i - 1];
        }

        for (int i = array.length - 1; i >= 0; i--) {
            output[count[array[i]] - 1] = array[i];
            count[array[i]]--;
        }

        System.arraycopy(output, 0, array, 0, array.length);
    }

    public static void main(String[] args) {
        int[] array = {4, 2, 2, 8, 3, 3, 1};
        int max = 8;

        countingSort(array, max);

        System.out.print("Sorted array: ");
        for (int value : array) {
            System.out.print(value + " ");
        }
    }
}