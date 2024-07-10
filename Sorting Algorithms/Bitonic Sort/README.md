# Bitonic Sort
Bitonic Sort is a classic parallel algorithm for sorting. 

 - The number of comparisons done by Bitonic sort is more than popular sorting algorithms like Merge Sort [ does O(log N) comparisons], but Bitonic sort is better for parallel implementation because we always compare elements in a predefined sequence and the sequence of comparison doesn’t depend on data. Therefore it is suitable for implementation in hardware and parallel processor array.
 - Bitonic Sort can only be done if the number of elements to sort is 2^n. The procedure of bitonic sequence fails if the number of elements is not in the aforementioned quantity precisely.

Complexity: O(log^2n)