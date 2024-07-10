import java.util.ArrayList;
import java.util.Collections;

/**
 * Demonstrates the Bucket Sort algorithm. 
 * The bucketSort method sorts an array of integers using buckets to distribute 
 * elements into different ranges. The algorithm then sorts each bucket 
 * individually and merges them back into the original array,
 * resulting in a sorted array. 
 * 
 * The main method showcases the usage of the bucketSort method on a sample array.
 */
public class BucketSort {
    public static void bucketSort(int[] arr, int numOfBuckets) {
        if (arr == null || arr.length == 0) {
            return;
        }

        int minValue = arr[0];
        int maxValue = arr[0];
        for (int value : arr) {
            if (value < minValue) {
                minValue = value;
            } else if (value > maxValue) {
                maxValue = value;
            }
        }

        int range = (maxValue - minValue) / numOfBuckets + 1;
        ArrayList<ArrayList<Integer>> buckets = new ArrayList<>(numOfBuckets);
        for (int i = 0; i < numOfBuckets; i++) {
            buckets.add(new ArrayList<>());
        }

        for (int value : arr) {
            int bucketIndex = (value - minValue) / range;
            buckets.get(bucketIndex).add(value);
        }

        int index = 0;
        for (ArrayList<Integer> bucket : buckets) {
            Collections.sort(bucket);
            for (int value : bucket) {
                arr[index++] = value;
            }
        }
    }

    public static void main(String[] args) {
        int[] arr = {29, 25, 3, 49, 9, 37, 21, 43};
        int numOfBuckets = 5;

        System.out.println("Array before sorting:");
        for (int num : arr) {
            System.out.print(num + " ");
        }

        bucketSort(arr, numOfBuckets);

        System.out.println("\nArray after Bucket Sort:");
        for (int num : arr) {
            System.out.print(num + " ");
        }
    }
}
