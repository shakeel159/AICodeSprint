
# FisherYates Shuffle

## This program demonstrates a the Fisher-Yates shuffle algorithm 

The first method called SwapValues is a bit of code that swaps current value i position with value of what positon j holds.

the first Suffle method called DoFisherYatesShuffle takes in a array and set i to last element of array
and goes through every elemen. here we use the swap SwapValues method to swap values from one of the random chosen number between 0 and i that is less then objetcs.length.
the Fisher-Yates shuffle basically is going through the array and swapping elements until every value in the array has been swapped at least once.

the AlternateShuffle starts from the begining not the End of the array like the last method.
This time, the random number is between zero and (objects.Length - i)-1.
the results are the same as the FisherYates but starts from beging instead of End.
