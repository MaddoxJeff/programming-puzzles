using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler21
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int temp1 = 0;
            int temp2 = 0;
            for (int i = 1; i < 10000; i++)
            {
                temp1 = divisor(i);
                temp2 = divisor(temp1);
                if (i == temp2 && temp1 != temp2 )
                    result += i;
            }
            Console.WriteLine(result);
        }
        public static int divisor(int n)
        {
            ArrayList arr = new ArrayList();
            for (int i = 1; i < n; i++)
            {
                if (n%i == 0)
                    arr.Add(i);
            }
            int sum = 0;
            foreach(int k in arr)
            {
                sum += k;
            }            
            return sum;
        }
    }
}
