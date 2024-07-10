# Cycle Sort
Cycle sort is an in-place, unstable sorting algorithm that is particularly useful when sorting arrays containing elements with a small range of values. It was developed by W. D. Jones and published in 1963.

The basic idea behind cycle sort is to divide the input array into cycles, where each cycle consists of elements that belong to the same position in the sorted output array. The algorithm then performs a series of swaps to place each element in its correct position within its cycle, until all cycles are complete and the array is sorted.

Complexity: O(n^2)