# Sorting Algorithm 


## Bubble Sort

1.  BubbleSort Method takes in paremeter of array of data
that needs to be sorted. while it is not sorted the algorithm
finds the first element using a forloop and the second element 
also using a nested forloop. if the first element is larger then the second
switch them to be in order. repeat this for the coming elements
and once the algorithm has gone through comparing each one it will statr from beging
to compare the new moved elements until it is all sorted. this takes time
2.  Avarge/Worst/Best Case = O(n^2)
3.


      Bubblesort(Data: values[])
         //Repeat until the array is sorted.
         Boolean: not_sorted = True
         While (not_sorted)
         // Assume we won't find a pair to swap.
            not_sorted = False
            // Search the array for adjacent items that are out of order.
            For i = 0 To <length of values> - 1

            // See if items i and i - 1 are out of order.
    
            If (values[i] < values[i - 1]) Then
                // Swap them.
                Data: temp = values[i]
                values[i] = values[i - 1]
                values[i - 1] = temp
 
                // The array isn't sorted after all.
                not_sorted = True
            End If
        Next i
    End While
End Bubblesort  

- Stephens, Rod. Essential Algorithms (pp. 171-173). Wiley. 


## Insertion Sort

1.  Insertion Sort Alorithm takes in array of data in wich
we set i to second element of our array. this is so we can
compare it to the element that come before it, our sorted numbers.
we start our loop with i = second element of array
if i is less then the element before we swap our current element back one.
we rapeat this until there is no number larger until we can break out of our inner loop
where i moves to the next element to compare.
2.  best case is O(n), 
and worst case is O(n2)
3.


    InsertionSort(data[] values)
        while(i = 1, i > length of values, i++)
            j = i;
            while(j > 0 && values[j-1] > values[j])
                int temp = values[j];
                values[j] = values[j - 1];
                values[j - 1] = temp;
                j--;
4.


## SelectionSort

1.  Selection Algorithm takes in leangth of array
and sets position of i = 0 and j to i +1;
the algorithm goes through each element in array and only 
swappping the smallest number j finds with i; unlike previous 
sorting algorthims selection sorts goes through each element 
of array before soing any swaps.
2.  O(n2) average and worst case
3.

      for i = 0 To < leangth of array -1
      for j = i+1 j < i
      //swap positions
      next i
      End Selection


4.

## HeapSort

1.  Sorting Algorithm uses heap data structire or 
a specialixed tree-based data structure(binary tree where 
every node holds value that is at least as large as the values
of its children).the algorithm takes the largest element wich
is the root element of the heap and replaceses with the one 
of the leaf elements(children). it does this until no more
elements left in the heap and array to sort.
2.  O(n log n) run time.
3.


      HeapSort(int[] array, int n)
      for(i = n/2 -1 to i >= 0)
        //call make heap
      i--
      for(i = n-2 to i >=0)
            int temp = arr[0];
            arr[i] = temp;
            //call make heap
      end

    MakeHeap(int[] array, int n, int i)
        Integer largest = i;
        Integer: child1 = 2 * index + 1
        Integer: child2 = 2 * index + 2
        if( child1 < n and array[child1] > array[largest])
            largest - child1;
         if( child2< n and array[child2] > array[largest])
             largest - child2;
        if(largest != child2)
            //swap
            call Make heap
        end

