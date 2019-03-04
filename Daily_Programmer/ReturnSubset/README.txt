# INFO

Given a list of integers S and a target number k, write a function that returns a subset of S that adds up to k. 
If such a subset cannot be made, then return null.

Integers can appear more than once in the list. You may assume all numbers in the list are positive.

For example, given S = [12, 1, 61, 5, 9, 2] and k = 24, return [12, 9, 2, 1] since it sums up to 24.

----------------------------------------------------------------------------------------------------------------------------------------

For this project I created a method called "addUp" that would accept the array and target value.
The array being passed into this method will be called "arr" while target will be called "target".
Before anything else, this method will sort arr, then remove any elements in arr that are larger than target.

I created two arrays inside this method.
  -Int "newArr" will store the values that add up to the target number.
  -Boolean "tempArr" a 2d array that will be used as a matrix to find the values that add up to target.

I created two loops inside this method.
  -A nested for loop whose outer loop goes through each element of arr, while the inner loop goes through 0 - target.
    This loop will fill out the boolean values for tempArr.
  -A while loop that examines the tempArr values and fills out newArr.
  
Here is a visual example on what tempArr will look like once it has gone through the nested for loop.

    0  1  2  3  4  5  6  7  8  9  10  11  12  13  14  15  16  17  18  19  20  21  22  23
 1  T  T  F  F  F  F  F  F  F  F  F   F   F   F   F   F   F   F   F   F   F   F   F   F 
 2  T  T  T  T  F  F  F  F  F  F  F   F   F   F   F   F   F   F   F   F   F   F   F   F 
 5  T  T  T  T  F  T  T  T  T  F  F   F   F   F   F   F   F   F   F   F   F   F   F   F 
 9  T  T  T  T  F  T  T  T  T  T  T   T   T   F   T   T   T   T   F   F   F   F   F   F 
12  T  T  T  T  F  T  T  T  T  T  T   T   T   T   T   T   F   T   T   T   T   T   T   T 


The inner loop itterates through columns, while the outer loop itterates through rows.
There is a base case to fill out the top row, since every other row is filled out with information on the row above it.
There are two rules that fill out each index
  -if the row# > column#, that index is = the bool directly above it.
      tempArr[row, column] = tempArr[(row - 1), column]
  -if the row# <= column#, that index is = the bool above, then left by the row#
      tempArr[row, column] = tempArr[(row - 1), (column - row)]
 
 The while loop starts at the bottom right corner of the matrix and moves up & left until it reaches the end.
 There are two rules to find the correct values.
  -if the index on the row above = true, move up one row.
      tempArr[row, column] = tempArr[(row-1), column];
      row--;
  -if the index on the row above = false, that row # is added to newArr. Then you move left by the row #, and up one.
      newArr[index] = arr[i];
      column -= arr[i];
      row--;
      
This will produce the array with the correct values that add up to the target number.
