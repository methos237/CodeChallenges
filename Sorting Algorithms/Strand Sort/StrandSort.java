import java.util.ArrayList;
import java.util.List;

public class StrandSort {

    public static List<Integer> strandSort(List<Integer> arr) {
        List<Integer> result = new ArrayList<>();
        while (!arr.isEmpty()) {
            List<Integer> sublist = new ArrayList<>();
            sublist.add(arr.remove(0));
            for (int i = 0; i < arr.size(); i++) {
                if (arr.get(i) > sublist.get(sublist.size() - 1)) {
                    sublist.add(arr.remove(i));
                    i--;
                }
            }
            result = merge(result, sublist);
        }
        return result;
    }

    private static List<Integer> merge(List<Integer> list1, List<Integer> list2) {
        List<Integer> merged = new ArrayList<>();
        int i = 0, j = 0;
        while (i < list1.size() && j < list2.size()) {
            if (list1.get(i) < list2.get(j)) {
                merged.add(list1.get(i));
                i++;
            } else {
                merged.add(list2.get(j));
                j++;
            }
        }
        while (i < list1.size()) {
            merged.add(list1.get(i));
            i++;
        }
        while (j < list2.size()) {
            merged.add(list2.get(j));
            j++;
        }
        return merged;
    }

    public static void main(String[] args) {
        List<Integer> arr = new ArrayList<>();
        arr.add(5);
        arr.add(3);
        arr.add(8);
        arr.add(2);
        arr.add(1);
        arr.add(4);
        arr.add(6);
        System.out.println("Unsorted Array: " + arr);
        List<Integer> sortedArr = strandSort(arr);
        System.out.println("Sorted Array: " + sortedArr);
    }
}