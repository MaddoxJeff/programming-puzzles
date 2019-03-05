# INFO

You are given the two integer arrays (arr1, arr2) and a int value (target).
Find a element in each array whose sum is the closest to the target number.
arr1 = {-1, 3, 8, 2, 9, 5} 
arr2 = {4, 1, 2, 10, 5, 20}
target = 24

--------------------------------------------------------------------------------------------------------------------------

I already know how to solve this problem using a nested for loop, so I wanted to try a different approach.
I created a method named "sumOf" that accepts two arrays and an int "arr1", "arr2", and "target".
This method will return another array that will hold the two values whose sum is closest to target.

The first thing I did was sort arr1 and arr2, since it's necessary for this approach to work.
If you imagine these two arrays as a matrix you can create a nice shortcut.
arr1 will move accross columns, while arr2 will move accross rows.
Here is a visual example 

Let's say the target is 8

   -1  2  3  5  8  9
1                  *                      
2                   
4                     
5                       
10                    
20                  

You need to start from the top right, and move to the bottom left.
Starting at arr1[c] and arr2[r]; Where c = 5 and r = 0. 
Adding those two values will return 10, which is greater than our target value.
Every value below it can be skipped, since all those values will be greater than 10.
While if the sum was smaller, you can skip every value to the left.
Here is what the matrix will look like as you traverse it.

   -1  2  3  5  8  9
1   -  -  -  6  9  10                      
2   -  -  -  7  -  -                     
4   -  -  7  9  -  -                       
5         8  -  -  -                         
10           -  -  -                      
20           -  -  -


With this concept I created a while loop that would itterate until it traversed the matrix from top right to bottom left completely.
As long as length of both arrays are the same you can use the formula.

limit = (arr1.Length-1  +  arr2.Length-1) - 1;
counter = 0;
while (counter < limit){
...
counter++;
}


