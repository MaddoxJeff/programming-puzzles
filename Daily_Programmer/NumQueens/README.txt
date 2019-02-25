#Nqueens Info
The N queens problem consists of putting one queen on every column (labeled a, b, c, ...) of an NxN chessboard,
such that no two queens are in the same row or diagonal.
Example:

8  . . . Q . . . .
7  . . . . . . . .
6  . . . . . . . .
5  . . . . . . Q .
4  Q . . . . . . .
3  . Q . . . Q . .
2  . . . . . . . Q
1  . . Q . Q . . .
   a b c d e f g h
   
   
------------------------------------------------------------------------------------------------------------------------------------------
   
This is the board I used based on the int array boardLayout.  Each value on the int array shows which column the queen is in.
While each index of the array shows which row the queen is on.

For finding the diagonal intersection I used the two-point formula |x1−x2|=|y1−y2|   Where x would be the value stored in the index,
and y would be the index position of the array.  The program runs at O(N2), so I would like to come back to this problem and optimize
it to run at O(N).
