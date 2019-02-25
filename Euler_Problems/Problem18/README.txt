#INFO

By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.

   3
  7 4
 2 4 6
8 5 9 3

That is, 3 + 7 + 4 + 9 = 23.

Find the maximum total from top to bottom of the triangle below:

               75
              95 64
             17 47 82
           18 35 87 10
          20 04 82 47 65
         19 01 23 75 03 34
        88 02 77 73 07 63 67
       99 65 04 28 06 16 70 92
      41 41 26 56 83 40 80 70 33
     41 48 72 33 47 32 37 16 94 29
    53 71 44 65 25 43 91 52 97 51 14
   70 11 33 28 77 73 17 78 39 68 17 57
  91 71 52 38 17 14 91 43 58 50 27 29 48
 63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23

---------------------------------------------------------------------------------------------------------------------------------------


For this problem I compared two lines at a time, starting from the bottom.
Using the example triangle I will show you how the algorithm works.

   3
  7 4
 2 4 6
8 5 9 3

The bottom line will be called arrBot, while the line above it will be called arrTop.
Using this triangle we would have arrBot = [8, 5, 9, 6] and arrTop = [2, 4, 6]
Compare the first value of arrTop(2) with the diagonal values of arrBot(8, 5)
The bottom value that produces a greater sum will be added to arrTop's current value.
Repeat this process with the rest of values from arrTop and your triangle should look like this now

    3
   7  4
 10 13 15
 
 Repeating this process until you reach the top will give you 23.
 
 
I decided to keep the triangle info in txt file named "triangleData.txt"  
I created a while loop that would pull two lines out at a time and then turn them into an array (arrBot, ArrTop)
The loop would Compare the bottom & top lines and store the added results in a seperate array.
After the first itteration the topArr would stop comparing with the botArr and instead compare with the seperate array.

As a little bonus I printed out each itteration as the triangle searches for the right path.
The end of the triangle produces the final answer.
 
 
