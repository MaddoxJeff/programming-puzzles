#INFO

In England the currency is made up of pound, £, and pence, p, and there are eight coins in general circulation:

1p, 2p, 5p, 10p, 20p, 50p, £1 (100p) and £2 (200p).
It is possible to make £2 in the following way:

1×£1 + 1×50p + 2×20p + 1×5p + 1×2p + 3×1p
How many different ways can £2 be made using any number of coins?

-------------------------------------------------------------------------------------------------------------------------------

Dynamic programming problems are always fun, which is why I picked this one out.
The pences are in an array that go through a method "numOfWays" which accepts an array and returns an int.
I created an int value "cap" to hold the max value we are allowed to reach.
I also created a temp array to hold the new values.

The outer for loop go through the pence array's length starting from 0, examining each value.
The inner for loop initializes a int "k" that's value is equal to pence[i].
This loops through 1 - 200, -> 2 - 200, -> 5 - 200, -> 10 - 200, -> 20 - 200, -> 50 - 200, -> 100 - 200, -> 200-200.
Through each loop values for temp array are updated if k or greater multiples of k add into the cap value being examined.
This means lower elements of temp will be updated fewer times, with lower values.
While higher elements of temp will be updated more frequently, and have larger values.
The last element in the temp array will give you the number of ways.
