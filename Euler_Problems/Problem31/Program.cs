using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler31
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pArray = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };
            int total = numOfWays(pArray);
            Console.WriteLine(total);
        }
        public static int numOfWays(int[] n)
        {
            int cap = 200;
            int[] temp = new int[cap + 1];
            temp[0] = 1;
            for (int i = 0; i < n.Length; i++)
            {
                for (int k = n[i]; k<= cap; k++)
                {
                    temp[k] += temp[k - n[i]];
                }
            }
            return temp[cap];
        }
    }
}
