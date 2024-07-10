def merge_sort(arr):
    if len(arr) <= 1:
        return arr
    mid = len(arr) // 2
    left = merge_sort(arr[:mid])
    right = merge_sort(arr[mid:])
    return merge(left, right)

def merge(left, right):
    result = []
    while left and right:
        if left[0] < right[0]:
            result.append(left.pop(0))
        else:
            result.append(right.pop(0))
    if left:
        result.extend(left)
    if right:
        result.extend(right)
    return result

def strand_sort(arr):
    runs = []
    while arr:
        run = [arr.pop(0)]
        i = 0
        while i < len(arr):
            if arr[i] > run[-1]:
                run.append(arr.pop(i))
            else:
                i += 1
        runs = merge(runs, run)
    return runs