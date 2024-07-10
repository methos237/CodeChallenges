# Bingo Sort
This Sorting Technique is similar to the Selection Sort in which we first find the smallest element called Bingo Element, and then we repeatedly iterate the elements of the array to get the correct positions of all the elements. Similarly, find the next bingo element for the next pass, and so on. Every distinct element is considered a Bingo Element and called out in increasing order.

Complexity: 

Average and Worst Case: O(M * N) where M = number of distinct elements and N = size of the array
Best Case:  O(N + M^2 )