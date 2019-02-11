using System;

namespace EulerProb
{
    class Program
    {
        static void Main(string[] args)
        {
            long longest = 2;
            long tempNew = 0;
            long tempi = 0;
            for(long i = 0; i < 1000000; i++)
            {
                tempNew = collatz(i);
               if (longest > tempNew)
                   continue;
               if(longest <= tempNew)               
                   longest = tempNew;
                   tempi = i;
            }
            Console.WriteLine("Largest collatz value is: " + tempi);
            Console.WriteLine("With a chain size of: " + longest);
        }
        public static long collatz(long n)
        {
            long counter = 0;
            while (n > 1)
            {
                counter++;
                if (n % 2 == 0)
                    n /= 2;
                else
                    n = (3 * n) + 1;
            }
            return counter;
        }
    }
}
