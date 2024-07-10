class Node:
    def __init__(self, key):
        self.key = key
        self.left = None
        self.right = None

def tree_insert(root, key):
    if root is None:
        return Node(key)
    if key < root.key:
        root.left = tree_insert(root.left, key)
    else:
        root.right = tree_insert(root.right, key)
    return root

def in_order_traversal(root, result):
    if root:
        in_order_traversal(root.left, result)
        result.append(root.key)
        in_order_traversal(root.right, result)

def tree_sort(arr):
    if not arr:
        return []
    root = None
    for key in arr:
        root = tree_insert(root, key)
    result = []
    in_order_traversal(root, result)
    return result

# Example Usage
arr = [5, 2, 8, 1, 3]
sorted_arr = tree_sort(arr)
print(sorted_arr)