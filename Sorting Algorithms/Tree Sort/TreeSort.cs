using System;

public class Node
{
    public int data;
    public Node left, right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}

public class BinaryTree
{
    Node root;

    public BinaryTree()
    {
        root = null;
    }

    void StoreSorted(Node root, int[] arr, ref int i)
    {
        if (root != null)
        {
            StoreSorted(root.left, arr, ref i);
            arr[i++] = root.data;
            StoreSorted(root.right, arr, ref i);
        }
    }

    Node Insert(Node node, int data)
    {
        if (node == null)
        {
            node = new Node(data);
        }
        else
        {
            if (data < node.data)
            {
                node.left = Insert(node.left, data);
            }
            else
            {
                node.right = Insert(node.right, data);
            }
        }
        return node;
    }

    public int[] TreeSort(int[] arr)
    {
        int i = 0;
        root = null;

        foreach (var data in arr)
        {
            root = Insert(root, data);
        }

        arr = new int[arr.Length];
        StoreSorted(root, arr, ref i);

        return arr;
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 5, 2, 8, 1, 3 };
        BinaryTree tree = new BinaryTree();

        arr = tree.TreeSort(arr);

        Console.WriteLine("Sorted array:");
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}