using System;
using System.Numerics;

namespace Eulerprob15
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger gridX = 20;
            BigInteger gridY = 20;
            Console.WriteLine(lattice(gridX, gridY));
        }
        public static BigInteger lattice(BigInteger n, BigInteger k)
        {
            BigInteger m = n + k;          
            BigInteger value = factorial(m) / (factorial(m - n) * factorial(n));
            return value;
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
        
    }
}
