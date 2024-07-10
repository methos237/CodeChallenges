# Bitonic Sort in Ruby

def bitonic_sort(arr)
    n = arr.length
    bitonic_merge_sort(arr, 0, n, 1)
  end
  
  def bitonic_merge_sort(arr, start, length, direction)
    if length > 1
      middle = length / 2
      bitonic_merge_sort(arr, start, middle, direction)
      bitonic_merge_sort(arr, start + middle, middle, -direction)
      bitonic_merge(arr, start, length, direction)
    end
  end
  
  def bitonic_merge(arr, start, length, direction)
    if length > 1
      middle = length / 2
      for i in start..(start + length - 1)
        if (arr[i] > arr[i + middle]) == (direction == 1)
          arr[i], arr[i + middle] = arr[i + middle], arr[i]
        end
      end
      bitonic_merge(arr, start, middle, direction)
      bitonic_merge(arr, start + middle, middle, direction)
    end
  end
  