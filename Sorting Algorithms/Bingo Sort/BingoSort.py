def bingo_sort(arr):
    n = len(arr)
    swapped = True

    while swapped:
        swapped = False
        for i in range(0, n-1, 2):
            if arr[i] > arr[i+1]:
                arr[i], arr[i+1] = arr[i+1], arr[i]
                swapped = True

        for i in range(1, n-1, 2):
            if arr[i] > arr[i+1]:
                arr[i], arr[i+1] = arr[i+1], arr[i]
                swapped = True

    return arr

# Example Usage
arr = [64, 34, 25, 12, 22, 11, 90]
sorted_arr = bingo_sort(arr)
print("Sorted array is:", sorted_arr)
