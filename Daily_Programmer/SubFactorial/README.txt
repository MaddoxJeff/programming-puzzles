#INFO

This program will compute the subfactorial, defined as the derangement of a set of n objects, 
or a permutation of the elements of a set, such that no element appears in its original position.  
We denote it as !n
Some basic definitions:
  !1 -> 0 because you always have {1}, meaning 1 is always in it's position.
  !2 -> 1 because you have {2,1}.
  !3 -> 2 because you have {2,3,1} and {3,1,2}.
And so forth.

-----------------------------------------------------------------------------------------------------------------------------

I solved this problem using the formula !n = (n!/e) where e is Euler's constant.
I started adding more functions to this, so I'm going to keep this project open for now and continue editing it.
