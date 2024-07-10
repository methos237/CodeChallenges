def pigeonhole_sort(arr):
    # Find minimum and maximum values in the array
    min_value = min(arr)
    max_value = max(arr)
    size = max_value - min_value + 1

    # Create pigeonholes
    holes = [0] * size

    # Populate pigeonholes with elements from the array
    for x in arr:
        holes[x - min_value] += 1

    # Put the elements back into the array in sorted order
    i = 0
    for count in range(size):
        while holes[count] > 0:
            holes[count] -= 1
            arr[i] = count + min_value
            i += 1

    return arr

# Test the pigeonhole sort algorithm
arr = [8, 3, 2, 7, 4, 6, 8]
sorted_arr = pigeonhole_sort(arr)
print("Sorted array is:", sorted_arr)