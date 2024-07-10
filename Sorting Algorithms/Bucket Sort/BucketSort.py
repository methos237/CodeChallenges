def bucket_sort(arr):
    """
    Sorts a list of elements using the Bucket Sort algorithm.

    The algorithm divides the input array into multiple buckets, 
    sorts each bucket individually, and then concatenates 
    the sorted buckets to obtain the final sorted array.
    
    Parameters:
        arr (list): The list of elements to be sorted.

    Returns:
        list: The sorted list of elements.
    """
    
    # Create a list of empty buckets
    buckets = [[] for _ in range(len(arr))]
    
    # Distribute elements into buckets
    for num in arr:
        index = int(num * len(arr))
        buckets[index].append(num)
    
    # Sort each bucket
    for bucket in buckets:
        bucket.sort()
    
    # Concatenate sorted buckets
    sorted_arr = [num for bucket in buckets for num in bucket]
    
    return sorted_arr

# Test the bucket sort algorithm
arr = [0.897, 0.565, 0.656, 0.1234, 0.665, 0.3434]
sorted_arr = bucket_sort(arr)
print("Sorted Array using Bucket Sort:", sorted_arr)
