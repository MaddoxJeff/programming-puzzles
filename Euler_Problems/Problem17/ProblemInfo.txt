#INFO

If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?

NOTE: Do not count spaces or hyphens. 
For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. 
The use of "and" when writing out numbers is in compliance with British usage.


-------------------------------------------------------------------------------------------------------------------------------------------

For this problem I would send the integer into the numOfLetters method. 
This would turn each individual int value into it's own array element.

Since I only needed to go up to 1000, I focused on integers in that range.
I created three different methods to return the length of integers.

oneDigit - would focus on (1-9) 
teen - would focus on (10-19)
secDigit - would focus on (20's - 90's)

Once the length is determined there is a series of if statements that will calculate which method will be called.


Any number that is 3 digits calls the oneDigit method
afterwards it automatically add 10 since that is = "hundred and"
unless that number ends in 00, then it's only 7 = "hundred"

  Any number that has 2 or more digits has to be checked if the second to last digit is "1"
  If so, the teen method will be called and skip the oneDigit method.

  Any number that has 2 or more digits has to be checked if the second to last digit is "0"
  If so, both teen & secDigit will be skipped and go straight to the oneDigit method.

If these two don't apply, the secDigit method is called, followed by the oneDigit method.

There is one special if statements that add's 11 to take into account for 1000 = "one thousand"


I'm glad I got this up and running, but it felt a little too brute force.  
Would like to replace all if statements with one loop if I could.
