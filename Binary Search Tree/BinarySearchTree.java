/**
 * Class representing a node in a binary search tree.
 */
class Node {
    int data;
    Node left;
    Node right;

    /**
     * Constructor to create a new Node.
     * @param data The data to be stored in the node.
     */
    public Node(int data) {
        this.data = data;
        left = null;
        right = null;
    }
}

/**
 * Class representing a binary search tree.
 */
class BinarySearchTree {
    private Node root;

    /**
     * Constructor to create an empty binary search tree.
     */
    public BinarySearchTree() {
        root = null;
    }

    /**
     * Method to insert a new node into the binary search tree.
     * @param data The data to be inserted.
     */
    public void insert(int data) {
        root = insertNode(root, data);
    }

    /**
     * Recursive helper method to insert a new node into the binary search tree.
     * @param root The root of the current subtree.
     * @param data The data to be inserted.
     * @return The updated root of the subtree.
     */
    private Node insertNode(Node root, int data) {
        // If the tree is empty, create a new node and return it as the root.
        if (root == null) {
            root = new Node(data);
            return root;
        }

        // Otherwise, recursively insert the node in the left or right subtree.
        if (data < root.data) {
            root.left = insertNode(root.left, data);
        } else if (data > root.data) {
            root.right = insertNode(root.right, data);
        }

        return root;
    }

    /**
     * Method to search for a value in the binary search tree.
     * @param data The value to search for.
     * @return true if the value is found, false otherwise.
     */
    public boolean search(int data) {
        return searchNode(root, data);
    }

    /**
     * Recursive helper method to search for a value in the binary search tree.
     * @param root The root of the current subtree.
     * @param data The value to search for.
     * @return true if the value is found, false otherwise.
     */
    private boolean searchNode(Node root, int data) {
        // If the tree is empty or the value is found at the root, return true.
        if (root == null || root.data == data) {
            return root != null;
        }

        // Otherwise, recursively search for the value in the left or right subtree.
        if (data < root.data) {
            return searchNode(root.left, data);
        } else {
            return searchNode(root.right, data);
        }
    }

    /**
     * Method to print the binary search tree in-order.
     */
    public void printInOrder() {
        printInOrder(root);
    }

    /**
     * Recursive helper method to print the binary search tree in-order.
     * @param root The root of the current subtree.
     */
    private void printInOrder(Node root) {
        if (root != null) {
            printInOrder(root.left);
            System.out.print(root.data + " ");
            printInOrder(root.right);
        }
    }
}

/**
 * Main class to test the binary search tree implementation.
 */
public class Main {
    public static void main(String[] args) {
        BinarySearchTree bst = new BinarySearchTree();

        // Insert values into the binary search tree.
        bst.insert(50);
        bst.insert(30);
        bst.insert(20);
        bst.insert(40);
        bst.insert(70);
        bst.insert(60);
        bst.insert(80);

        // Print the binary search tree in-order.
        System.out.println("Binary Search Tree (In-order):");
        bst.printInOrder();

        // Search for a value in the binary search tree.
        int searchValue = 40;
        System.out.println("\nSearching for " + searchValue + ": " + bst.search(searchValue));
    }
}