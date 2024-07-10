def merge_sort(arr):
    """
    Sorts a list of elements using the 3-way Merge Sort algorithm.

    Parameters:
        arr (list): The list of elements to be sorted.

    Returns:
        list: The sorted list of elements.
    """
    if len(arr) <= 1:
        return arr

    mid1 = len(arr) // 3
    mid2 = mid1 * 2

    left = merge_sort(arr[:mid1])
    middle = merge_sort(arr[mid1:mid2])
    right = merge_sort(arr[mid2:])

    return merge(left, middle, right)


def merge(left, middle, right):
    """
    Merges three sorted lists into a single sorted list.

    Parameters:
        left (list): The left sorted list.
        middle (list): The middle sorted list.
        right (list): The right sorted list.

    Returns:
        list: The merged sorted list.
    """
    merged = []
    i = j = k = 0

    while i < len(left) and j < len(middle) and k < len(right):
        if left[i] <= middle[j] and left[i] <= right[k]:
            merged.append(left[i])
            i += 1
        elif middle[j] <= left[i] and middle[j] <= right[k]:
            merged.append(middle[j])
            j += 1
        else:
            merged.append(right[k])
            k += 1

    while i < len(left):
        merged.append(left[i])
        i += 1

    while j < len(middle):
        merged.append(middle[j])
        j += 1

    while k < len(right):
        merged.append(right[k])
        k += 1

    return merged