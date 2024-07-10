def odd_even_brick_sort(arr):
    """
    Perform odd-even transposition sort (Brick Sort) on the input array.

    Parameters:
    arr (list): List to be sorted

    Returns:
    list: Sorted list
    """
    n = len(arr)
    sorted = False
    while not sorted:
        sorted = True
        for i in range(1, n - 1, 2):
            if arr[i] > arr[i + 1]:
                arr[i], arr[i + 1] = arr[i + 1], arr[i]
                sorted = False
        for i in range(0, n - 1, 2):
            if arr[i] > arr[i + 1]:
                arr[i], arr[i + 1] = arr[i + 1], arr[i]
                sorted = False
    return arr

# Example Usage
my_list = [64, 34, 25, 12, 22, 11, 90]
sorted_list = odd_even_brick_sort(my_list)
print(sorted_list)
