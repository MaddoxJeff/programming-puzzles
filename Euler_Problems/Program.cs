using System;
using System.Numerics;

namespace EulerProb16
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = 2;
            BigInteger exp = 1000;
            BigInteger k = power(n, exp);
            Console.WriteLine(n + "^" + exp + ": ");
            Console.WriteLine(k + " =");
            Console.WriteLine(sumOfDigits(k));
        }
        public static BigInteger power(BigInteger n, BigInteger exp)
        {
            BigInteger value = n;
            while (exp > 1)
            {
                value = value * n;
                exp--;
            }
            return value;
        }
        public static BigInteger sumOfDigits(BigInteger n)
        {
            BigInteger temp = 0;
            BigInteger len = n.ToString().Length;
            BigInteger value = 0;

            while (n > 0)
            {
                temp = (n % 10);
                value += temp;
                n = n / 10;
            }
            return value;
        }
    }
}
