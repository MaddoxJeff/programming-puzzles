using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProb04
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int temp = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 100; i < 1000; i++)
            {
                for(int k = 0 + i; k < 1000; k++)
                {
                    temp = k * i;
                    if (checkPal(temp) == true && temp > result)
                        result = temp;
                }
            }
            watch.Stop();
            Console.WriteLine(result);
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs);
        }
        public static Boolean checkPal(int n)
        {           
            int original = n;
            int reverse = 0;
            int remainder = 0;
            while (original > 0)
            {
                remainder = original % 10;
                reverse = reverse * 10 + remainder;
                original /=10;
            }
            if (n == reverse)            
                return true;               
            else 
                return false;                              
        }

    }
}
