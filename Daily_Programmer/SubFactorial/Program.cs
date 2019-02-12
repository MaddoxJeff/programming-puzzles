using System;
using System.Numerics;

namespace subFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = 9;
            Console.WriteLine("Number: " + n);
            BigInteger k = factorial(n);
            double num = convDouble(k);
            Console.WriteLine("Factorial: " + num);
            double e = 2.718281828459;
            double solution = num / e;
            Console.WriteLine("Derangement: " + Math.Round(solution));
        }
        public static BigInteger factorial(BigInteger num)
        {
            BigInteger res = 1;
            while (num != 1)
            {
                res = res * num;
                num = num - 1;
            }
            return res;
        }
        public static double convDouble(BigInteger n)
        {
            BigInteger temp = 0;
            
            int len = n.ToString().Length;
            BigInteger[] sep = new BigInteger[len];
            int counter = len;

            while (n > 0)
            {
                counter--;
                temp = (n % 10);
                sep[counter] = temp;
                n = n / 10;
            }
            String res = string.Join("", sep);
            double d = Convert.ToDouble(res);
            return d;

        }
    }
}
