using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfTwoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { -1, 3, 8, 2, 9, 5 };
            int[] arr2 = new int[] { 4, 1, 2, 10, 5, 20 };
            int target = 24;
            int[] result = sumOf(arr1, arr2, target);
            Console.WriteLine(string.Join(",", result));
        }
        public static int[] sumOf(int[] arr1, int[] arr2, int target)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);
            int len1 = arr1.Length - 1;
            int len2 = arr2.Length - 1;
            int limit = ((arr1.Length-1) + (arr2.Length-1)) - 1;
            int counterArr2 = 0;
            int temp = 0;
            int[] close = new int[2];
            int tempClose = 0;
            int closest = 0;
            int counter = 0;
            while (counter < limit)
            {
                temp = arr1[len1] + arr2[counterArr2];
                //base case for first itteration
                if (counter == 0)
                {
                    closest = target - temp;
                    Math.Abs(closest);
                    close[0] = arr1[len1];
                    close[1] = arr2[counterArr2];
                    counter++;
                    continue;
                }
                //check if close to target
                tempClose = target - temp;
                Math.Abs(tempClose);
                if(tempClose < closest)
                {
                    close[0] = arr1[len1];
                    close[1] = arr2[counterArr2];
                }
                //check if values equal target
                if (temp == target)
                {
                    close[0] = arr1[len1];
                    close[1] = arr2[counterArr2];
                    break;
                }
                //updates matrix position
                if (temp < target)
                    counterArr2++;
                if (temp > target)
                    len1--;
                //counts itteration
                counter++;
            }
            return close;
        }
    }
}
