using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targetArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12, 1, 61, 5, 9, 2 };
            int target = 24;
            int[] result = addUp(arr, target);
            Console.WriteLine(string.Join(",", result));

        }
        public static int[] addUp(int[] arr, int target)
        {
            Array.Sort(arr);
            int len = arr.Length - 1;
            //removes any number larger than the target number
            while (arr[len] > 24)
            {
                Array.Resize(ref arr, arr.Length - 1);
                len--;
            }
            Boolean[,] tempArr = new Boolean[arr.Length,target];           
            int[] newArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for(int k = 0; k < target; k++)
                {
                    //base case
                    if (i == 0 && k == 0)
                        tempArr[i,k] = true;
                    if (i == 0 && k != 0)
                    {
                        if (k == arr[i])
                            tempArr[i,k] = true;
                        else
                            tempArr[i,k] = false;
                    }
                    if (arr[i] > k && i != 0)
                        tempArr[i, k] = tempArr[(i - 1), k];
                    if (arr[i] <= k && i != 0)
                        tempArr[i, k] = tempArr[(i - 1), (k - arr[i])];
                }
                
            }
            int kCount = target - 1;
            int iCount = arr.Length-1;
            int counter = 0;
            int index = 0;
            while(iCount > 0)
            {
                if (tempArr[iCount, kCount] == true && tempArr[(iCount - 1), kCount] == true)
                    iCount--;
                else
                {
                    newArr[index] = arr[iCount];
                    counter += arr[iCount];
                    kCount -= arr[iCount];
                    iCount--;
                    index++;
                }
            }
            //checks last value;
            if (counter != target)
                newArr[index] = arr[0];
            //shorten array to correct size
            int shorten = newArr.Length -1;
            while (newArr[shorten] != 0)
            {
                Array.Resize(ref newArr, newArr.Length - 1);
                shorten--;
            }
            Array.Resize(ref newArr, newArr.Length - 1);
            return newArr;
        }
    }
}
