using System;

/// <summary>
/// Represents a node in a binary search tree.
/// </summary>
public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
    }
}

/// <summary>
/// Represents a binary search tree.
/// </summary>
public class BinarySearchTree
{
    public TreeNode Root { get; private set; }

    /// <summary>
    /// Inserts a value into the binary search tree.
    /// </summary>
    /// <param name="value">The value to insert.</param>
    public void Insert(int value)
    {
        if (Root == null)
        {
            Root = new TreeNode(value);
            return;
        }

        InsertRecursive(Root, value);
    }

    private void InsertRecursive(TreeNode node, int value)
    {
        if (value < node.Value)
        {
            if (node.Left == null)
            {
                node.Left = new TreeNode(value);
            }
            else
            {
                InsertRecursive(node.Left, value);
            }
        }
        else
        {
            if (node.Right == null)
            {
                node.Right = new TreeNode(value);
            }
            else
            {
                InsertRecursive(node.Right, value);
            }
        }
    }

    /// <summary>
    /// Searches for a value in the binary search tree.
    /// </summary>
    /// <param name="value">The value to search for.</param>
    /// <returns>True if the value is found, false otherwise.</returns>
    public bool Search(int value)
    {
        return SearchRecursive(Root, value);
    }

    private bool SearchRecursive(TreeNode node, int value)
    {
        if (node == null)
        {
            return false;
        }

        if (value == node.Value)
        {
            return true;
        }

        if (value < node.Value)
        {
            return SearchRecursive(node.Left, value);
        }
        else
        {
            return SearchRecursive(node.Right, value);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create a new binary search tree
        BinarySearchTree bst = new BinarySearchTree();

        // Insert values into the binary search tree
        bst.Insert(10);
        bst.Insert(5);
        bst.Insert(15);
        bst.Insert(3);
        bst.Insert(7);

        // Search for values in the binary search tree
        Console.WriteLine(bst.Search(5));   // Output: True
        Console.WriteLine(bst.Search(12));  // Output: False
    }
}