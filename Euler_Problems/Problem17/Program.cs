using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler17
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1000;
            int totalNum = 0;
            for(int i = 1; i <= num; i++)
            {
               totalNum += numOfLetters(i);
            }
            Console.WriteLine(totalNum);
            Console.WriteLine(numOfLetters(num));
        }
        public static int numOfLetters(int n)
        {
            //split int up
            int totalNum = 0;
            int[] split = new int[n.ToString().Length];
            int temp = n;
            int counter = n.ToString().Length-1;
            while (temp > 0)
            {
                split[counter] = (temp % 10);
                temp = temp / 10;
                counter--;
            }
            //check first 
            int arrCounter = 0;
            if (split.Length == 4)
                totalNum = 11;
            // 3 digit numbers.  
            if(split.Length == 3)
            {
                //Takes first int + "hundred and"
                totalNum += oneDigit(split[arrCounter]) + 10;
                arrCounter++;
                //checks for 3 digit numbers ending in 00   ex: "200" "600"
                if (split[1] == 0 && split[2] == 0)
                    totalNum -= 3;
                //checks for teens
                if (split[1]==1)
                    totalNum += teen(split[arrCounter+1]);
                //checks for d's
                if (split[1] != 1)
                {
                    totalNum += secDigit(split[arrCounter]);
                    arrCounter++;
                    //adds last digit
                    totalNum += oneDigit(split[arrCounter]);
                }
            }
            //2 digit d's
            if (split.Length == 2 && split[arrCounter] != 1)
            {
                totalNum += secDigit(split[0]);
                arrCounter++;
                totalNum += oneDigit(split[1]);
                arrCounter++;
            }
            //teens 10 - 19
            if (split.Length == 2 && split[0]==1)
            {
                totalNum += teen(split[1]);
            }
            //Checks the last digit
            if (split.Length == 1)
            {
                totalNum += oneDigit(split[arrCounter]);
                arrCounter++;
            }
            return totalNum;
        }
        public static int oneDigit(int n)
        {
            int num = 0;
            if (n == 1)
                num = 3;
            if (n == 2)
                num = 3;
            if (n == 3)
                num = 5;
            if (n == 4)
                num = 4;
            if (n == 5)
                num = 4;
            if (n == 6)
                num = 3;
            if (n == 7)
                num = 5;
            if (n == 8)
                num = 5;
            if (n == 9)
                num = 4;
            return num;
        }
        public static int teen(int n)
        {
            int num = 0;
            if (n == 0)
                num = 3;
            if (n == 1)
                num = 6;
            if (n == 2)
                num = 6;
            if (n == 3)
                num = 8;
            if (n == 4)
                num = 8;
            if (n == 5)
                num = 7;
            if (n == 6)
                num = 7;
            if (n == 7)
                num = 9;
            if (n == 8)
                num = 8;
            if (n == 9)
                num = 8;
            return num;
        }
        public static int secDigit(int n)
        {
            int num = 0;
            if (n == 2)
                num = 6;
            if (n == 3)
                num = 6;
            if (n == 4)
                num = 5;
            if (n == 5)
                num = 5;
            if (n == 6)
                num = 5;
            if (n == 7)
                num = 7;
            if (n == 8)
                num = 6;
            if (n == 9)
                num = 6;
            return num;
        }
    }
}
