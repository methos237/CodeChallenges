class Node:
    """
    Represents a node in a Binary Search Tree.
    """

    def __init__(self, data):
        """
        Initializes a new instance of the Node class.

        Parameters:
            data (any): The data value to be stored in the node.
        """
        self.data = data
        self.left = None
        self.right = None


class BinarySearchTree:
    """
    Represents a Binary Search Tree.
    """

    def __init__(self):
        """
        Initializes a new instance of the BinarySearchTree class.
        """
        self.root = None

    def insert(self, data):
        """
        Inserts a new node with the given data into the Binary Search Tree.

        Parameters:
            data (any): The data value to be inserted.
        """
        if self.root is None:
            self.root = Node(data)
        else:
            self._insert_recursive(self.root, data)

    def _insert_recursive(self, node, data):
        """
        Helper method to recursively insert a new node into the Binary Search Tree.

        Parameters:
            node (Node): The current node being checked.
            data (any): The data value to be inserted.
        """
        if data < node.data:
            if node.left is None:
                node.left = Node(data)
            else:
                self._insert_recursive(node.left, data)
        else:
            if node.right is None:
                node.right = Node(data)
            else:
                self._insert_recursive(node.right, data)

    def search(self, data):
        """
        Searches for a node with the given data in the Binary Search Tree.

        Parameters:
            data (any): The data value to be searched.

        Returns:
            Node: The node containing the data value, or None if not found.
        """
        return self._search_recursive(self.root, data)

    def _search_recursive(self, node, data):
        """
        Helper method to recursively search for a node in the Binary Search Tree.

        Parameters:
            node (Node): The current node being checked.
            data (any): The data value to be searched.

        Returns:
            Node: The node containing the data value, or None if not found.
        """
        if node is None or node.data == data:
            return node
        if data < node.data:
            return self._search_recursive(node.left, data)
        return self._search_recursive(node.right, data)

    def delete(self, data):
        """
        Deletes a node with the given data from the Binary Search Tree.

        Parameters:
            data (any): The data value to be deleted.
        """
        self.root = self._delete_recursive(self.root, data)

    def _delete_recursive(self, node, data):
        """
        Helper method to recursively delete a node from the Binary Search Tree.

        Parameters:
            node (Node): The current node being checked.
            data (any): The data value to be deleted.

        Returns:
            Node: The updated node structure after deletion.
        """
        if node is None:
            return node
        if data < node.data:
            node.left = self._delete_recursive(node.left, data)
        elif data > node.data:
            node.right = self._delete_recursive(node.right, data)
        else:
            if node.left is None:
                return node.right
            elif node.right is None:
                return node.left
            else:
                node.data = self._find_min_value(node.right)
                node.right = self._delete_recursive(node.right, node.data)
        return node

    def _find_min_value(self, node):
        """
        Helper method to find the minimum value in a Binary Search Tree.

        Parameters:
            node (Node): The current node being checked.

        Returns:
            any: The minimum value found in the tree.
        """
        min_value = node.data
        while node.left is not None:
            min_value = node.left.data
            node = node.left
        return min_value