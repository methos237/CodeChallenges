/**
 * Shell Sort implementation in Java
 */
public class ShellSort {
    
    /**
     * Sorts the array using Shell Sort algorithm
     * @param arr the array to be sorted
     */
    public void shellSort(int[] arr) {
        int n = arr.length;
        
        for (int gap = n/2; gap > 0; gap /= 2) {
            for (int i = gap; i < n; i++) {
                int temp = arr[i];
                int j;
                for (j = i; j >= gap && arr[j - gap] > temp; j -= gap) {
                    arr[j] = arr[j - gap];
                }
                arr[j] = temp;
            }
        }
    }
    
    /**
     * A utility function to print the array
     * @param arr the array to be printed
     */
    public void printArray(int[] arr) {
        int n = arr.length;
        for (int i = 0; i < n; i++) {
            System.out.print(arr[i] + " ");
        }
        System.out.println();
    }
    
    public static void main(String[] args) {
        int[] arr = {12, 34, 54, 2, 3};
        ShellSort sorter = new ShellSort();
        
        System.out.println("Array before sorting:");
        sorter.printArray(arr);
        
        sorter.shellSort(arr);
        
        System.out.println("Array after sorting:");
        sorter.printArray(arr);
    }
}