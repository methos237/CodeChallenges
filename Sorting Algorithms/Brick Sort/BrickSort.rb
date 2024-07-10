# Brick Sort Algorithm in Ruby

def brick_sort(arr)
    n = arr.length
    sorted = false
  
    while !sorted
      sorted = true
      0.upto(n - 2) do |i|
        if arr[i] > arr[i + 1]
          arr[i], arr[i + 1] = arr[i + 1], arr[i]
          sorted = false
        end
      end
  
      (n - 2).downto(0) do |i|
        if arr[i] > arr[i + 1]
          arr[i], arr[i + 1] = arr[i + 1], arr[i]
          sorted = false
        end
      end
    end
  
    arr
  end
  
  # Example usage
  arr = [5, 2, 8, 1, 9, 3, 7, 4, 6]
  sorted_arr = brick_sort(arr)
  puts sorted_arr # Output: [1, 2, 3, 4, 5, 6, 7, 8, 9]
  