def bubble_sort(array)
  # Iterate through the array multiple times, each time comparing adjacent elements and swapping if necessary
  # The largest element in the unsorted part of the array "bubbles" to the end in each iteration
  # Repeat until the array is sorted
  n = array.length
  (0...n).each do |i|
    (0...n-i-1).each do |j|
      # Compare adjacent elements
      if array[j] > array[j+1]
        # Swap the elements if they are in the wrong order
        array[j], array[j+1] = array[j+1], array[j]
      end
    end
  end
  array
end