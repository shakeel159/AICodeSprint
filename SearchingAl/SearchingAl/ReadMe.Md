
# Searching Algorithms

for searching for an element in a data structure. often catagorized as 
sequential or interval

### sequential
	A data structure is traversed sequentially and every element is checked.
### Interval 
	Optimized for sorted data-structures, these algorithms can be more efficient.


## Linear Search

1.	Linear code starts from the first element in array and one
by one compares each element of the array. hence i = 0;
if i matches with an element we return the element and its data 
else break

2.	Worst-case: O(n), Best-case: O(1), Average: O(n/2)

3. 
	
	i = 0
	if l = t go to line 4
		i++ go to line 2
	if i < n then return i
end


## Binary Search

1.	Using A sorted set of data the binary seatch starts in the middle of our
array. if the middle element matches we found our target. if not it determines
which half of the array the target element may be. is it less then or greater then
the middle element hence a sorted array is needed.

2.	

3.	


	function binary_search(A, n, T) is
    L := 0
    R := n − 1
    while L ≤ R do
        m := floor((L + R) / 2)
        if A[m] < T then
            L := m + 1
        else if A[m] > T then
            R := m − 1
        else:
            return m
    return unsuccessful



## Interpolation Search

1.  also requires a sorted data set.Interpolation search uses keys. For interpolation
search to work efficiently data must be uniformly distributed (in addition to being sorted).

2.  Best case: O (log log n), Worst case:  O(n)

3.  
    
Interpolation(data[] array, integer targetValue)
    integer left = 0;
    integer right = array leangth - 1
    integer value;
    while left <= right and targetValue >= array[left] and tagertValue <= array[right]
    if array[value] == targetValue
        return target
    if(array[value] < targetValue)
        left = targetValue +1;
    if(array[value] < targetValue)
        left = targetValue -1;
return -1;




List the algorithm name
Describe the algorithm
Show asymptotic notation (best and worse case)
Show the algorithm as pseudocode