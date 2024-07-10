def bubble_sort(arr):
    """
    Sorts a list of elements using the Bubble Sort algorithm.

    Parameters:
        arr (list): The list of elements to be sorted.

    Returns:
        list: The sorted list of elements.
    """
    n = len(arr)

    # Traverse through all array elements
    for i in range(n-1):
        # Last i elements are already in place
        for j in range(0, n-i-1):
            # Swap if the element found is greater than the next element
            if arr[j] > arr[j+1]:
                arr[j], arr[j+1] = arr[j+1], arr[j]

    return arr