#INFO

Conway's Game of Life takes place on an infinite two-dimensional board of square cells. 
Each cell is either dead or alive, and at each tick, the following rules apply:

Any live cell with less than two live neighbours dies.
Any live cell with two or three live neighbours remains living.
Any live cell with more than three live neighbours dies.
Any dead cell with exactly three live neighbours becomes a live cell.
A cell neighbours another cell if it is horizontally, vertically, or diagonally adjacent.

Implement Conway's Game of Life. 
It should be able to be initialized with a starting list of live cell coordinates and the number of steps it should run for. 
Once initialized, it should print out the board state at each step. Since it's an infinite board, 
print out only the relevant coordinates, i.e. from the top-leftmost live cell to bottom-rightmost live cell.

You can represent a live cell with an asterisk (*) and a dead cell with a dot (.).

------------------------------------------------------------------------------------------------------------------------------------

#Project Layout

The program gets the grid and default values from a "lifeBoard.txt" file.
This get's turned into a multi dimensional array called "board" with 0's being dead, and 1's being alive.

There are two methods that check a cell in the grid. aCheckNeighbor and dCheckNeighbor.
A cell get's passed to aCheckNeighbor if it's alive, and dCheckNeighbor if it's dead.
Inside each of these methods is a while loop that checks the surrounding 8 cells in 3 loop itterations.
Here is a visual example if the cell we are examining is [2,2] let's call it [n,m]

[1,1] [2,1] [3,1]
[1,2] [n,m] [3,2]
[1,3] [2,3] [3,3]

the m value stays the same throughout the top, middle and bottom.
I started off the loop at (m-1) as it increments through each loop.
Three conditional statements are asked for the left, middle, and right OR (n-1),(n+1), and (n).

                      top row                         
[1,1] [2,1] [3,1]      -->        [(n-1),m] [n,m] [(n+1),m]   m++  
                     middle row 
[1,2] [n,m] [3,2]      -->        [(n-1),m] [n,m] [(n+1),m]   m++
                     bottom row
[1,3] [2,3] [3,3]      -->        [(n-1),m] [n,m] [(n+1),m]   m++         


values for "alive" and "dead" are counted during this loop.
A value for [n,m] is added during this loop, there is a statement at the end to delete this extra "alive" or "dead".
Following the rules of Conway's Game of Life, this method will return a '.' if dead, or '*' if alive.


There are two methods called "loop" and "loopChar".
The loop method returns the new board in the form of 0's and 1's under the name "tempBoard"
The loopChar method returns the new board in the form of '.'s and '*'s under the name "boardEvolve"

The last method is called "printBoard" which takes the "boardEvolve" array and prints accordingly.
This method is in a for loop that prints the following 10 ticks of Conway's Game of Life.
There is 1 second delay between each tick so you can get a sense of progression.

#THOUGHTS

Here are some current issues that I have with this project.
- The board doesn't grow as it reaches the edge.
- Checking cell values at 0 or array.length causes an out of bounds exception.
- loop and loopChar should be in one loop, instead of doing a nested twice.


I'm going to rewrite this in a C# Form Application with these changes in mind.
The visuals are the star of the show, and this current layout is very underwhelming.
