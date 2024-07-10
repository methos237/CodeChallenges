import java.util.ArrayList;
import java.util.List;

class Node {
    int key;
    Node left, right;

    public Node(int item) {
        key = item;
        left = right = null;
    }
}

public class TreeSort {
    Node root;

    TreeSort() {
        root = null;
    }

    void insert(int key) {
        root = insertRec(root, key);
    }

    Node insertRec(Node root, int key) {
        if (root == null) {
            root = new Node(key);
            return root;
        }

        if (key < root.key)
            root.left = insertRec(root.left, key);
        else if (key > root.key)
            root.right = insertRec(root.right, key);

        return root;
    }

    void inOrderRec(Node root, List<Integer> sortedList) {
        if (root != null) {
            inOrderRec(root.left, sortedList);
            sortedList.add(root.key);
            inOrderRec(root.right, sortedList);
        }
    }

    List<Integer> treeSort(int[] arr) {
        for (int key : arr) {
            insert(key);
        }

        List<Integer> sortedList = new ArrayList<>();
        inOrderRec(root, sortedList);

        return sortedList;
    }

    public static void main(String[] args) {
        TreeSort treeSort = new TreeSort();
        int[] arr = {5, 2, 8, 1, 3};
        List<Integer> sortedList = treeSort.treeSort(arr);

        System.out.println("Sorted Array: " + sortedList);
    }
}