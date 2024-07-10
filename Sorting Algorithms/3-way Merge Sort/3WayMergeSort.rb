def merge_sort(array)
  return array if array.length <= 1

  mid = array.length / 3
  left = merge_sort(array[0...mid])
  middle = merge_sort(array[mid...2*mid])
  right = merge_sort(array[2*mid..-1])

  merge(merge(left, middle), right)
end

def merge(left, right)
  result = []

  while left.length > 0 && right.length > 0
    if left[0] <= right[0]
      result << left.shift
    else
      result << right.shift
    end
  end

  # Append any remaining elements
  result.concat(left).concat(right)
end