# Bucket Sort Algorithm in Ruby

def bucket_sort(arr)
    # Find the maximum element in the array
    max_element = arr.max
  
    # Create buckets
    buckets = Array.new(max_element + 1) { [] }
  
    # Distribute the elements of the array into different buckets
    arr.each do |x|
      buckets[x].push(x)
    end
  
    # Sort the elements in each bucket
    sorted_arr = []
    buckets.each do |bucket|
      bucket.sort.each { |x| sorted_arr.push(x) }
    end
  
    return sorted_arr
  end
  