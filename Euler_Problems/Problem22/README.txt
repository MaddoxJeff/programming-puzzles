#INFO

Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, 
begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, 
multiply this value by its alphabetical position in the list to obtain a name score.

For example, when the list is sorted into alphabetical order, 
COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. 
So, COLIN would obtain a score of 938 × 53 = 49714.

What is the total of all the name scores in the file?

----------------------------------------------------------------------------------------------------------------------------------

For this problem I turned the "p022_names.txt" file into a string array.
Each index in the string was split by the ','
The first and last character from each string was removed, making sure no qoutes were present.

I created a method called "stringToNumber" that would accept a string and return an integer.
This method would go through each character of the string, and sum up it's corresponding int value.

Back in the main method I sorted the array using the Array.Sort method, and created a loop to go through the array.
The loop pulls the int information from "stringToNumber" then multiplies it by it's (index +1)
That number then get's added to the total int value until the array is completely scanned.
