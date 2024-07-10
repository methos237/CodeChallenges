def permute_sort(arr):
    """
    This function sorts a list of elements using permutation sort algorithm.
    
    Parameters:
    arr (list): List of elements to be sorted
    
    Returns:
    list: Sorted list
    """
    if len(arr) == 0:
        return arr
    else:
        return min(arr) + permute_sort([x for x in arr if x < min(arr)]) + [x for x in arr if x == min(arr)] + permute_sort([x for x in arr if x > min(arr)])

# Example Usage
my_list = [4, 2, 7, 1, 3]
sorted_list = permute_sort(my_list)
print(sorted_list)