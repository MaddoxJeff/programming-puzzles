using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int counter = 0;
            while(counter < 10001)
            {
                n++;
                if (isPrime(n) == true)
                    counter++;
                
            }
            Console.WriteLine(n);
        }
        public static Boolean isPrime(int n)
        {
            int counter = 0;
            if (n == 2)
            {
                return true;
            }
            else if (n % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
