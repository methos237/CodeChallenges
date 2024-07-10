def comb_sort(arr):
    n = len(arr)
    gap = n
    shrink = 1.3
    sorted = False
    
    while not sorted:
        gap = int(gap / shrink)
        if gap <= 1:
            gap = 1
            sorted = True
        else:
            sorted = False
        
        i = 0
        while i + gap < n:
            if arr[i] > arr[i + gap]:
                arr[i], arr[i + gap] = arr[i + gap], arr[i]
                sorted = False
            i += 1
    
    return arr

# Example Usage
arr = [64, 34, 25, 12, 22, 11, 90]
sorted_arr = comb_sort(arr)
print("Sorted array is:", sorted_arr)