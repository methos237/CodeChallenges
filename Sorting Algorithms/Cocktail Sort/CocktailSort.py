def cocktail_sort(arr):
    """
    Sorts a list of elements using the Cocktail or Bidirectional Bubble Sort algorithm.

    The algorithm sorts an array of integers by iterating over the array in both directions,
    swapping elements if they are in the wrong order. The process is repeated until the array is fully sorted.
    
    Parameters:
        arr (list): The list of elements to be sorted.

    Returns:
        list: The sorted list of elements.
    """
    n = len(arr)
    swapped = True
    start = 0
    end = n - 1

    while swapped:
        swapped = False

        for i in range(start, end):
            if arr[i] > arr[i + 1]:
                arr[i], arr[i + 1] = arr[i + 1], arr[i]
                swapped = True

        if not swapped:
            break

        swapped = False

        end -= 1

        for i in range(end - 1, start - 1, -1):
            if arr[i] > arr[i + 1]:
                arr[i], arr[i + 1] = arr[i + 1], arr[i]
                swapped = True

        start += 1

    return arr

# Example Usage
arr = [64, 34, 25, 12, 22, 11, 90]
sorted_arr = cocktail_sort(arr)
print("Sorted array is:", sorted_arr)