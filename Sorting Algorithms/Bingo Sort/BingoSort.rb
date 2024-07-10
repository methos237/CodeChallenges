# Bingo Sort Algorithm

def bingo_sort(arr)
    n = arr.length
    min_idx = 0
  
    (0...n).each do |i|
      min_idx = i
      (i + 1...n).each do |j|
        min_idx = j if arr[j] < arr[min_idx]
      end
      arr[i], arr[min_idx] = arr[min_idx], arr[i]
    end
  
    arr
  end
  
  # Example usage
  arr = [64, 34, 25, 12, 22, 11, 90]
  sorted_arr = bingo_sort(arr)
  puts "Sorted array: #{sorted_arr}"
  