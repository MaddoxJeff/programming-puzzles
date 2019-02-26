using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Euler20
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = 100;
            n = factorial(n);
            Console.WriteLine(factDigit(n));
        }
        public static BigInteger factorial(BigInteger n)
        {
            BigInteger res = 1;
            while (n != 1)
            {
                res = res * n;
                n = n - 1;
            }
            return res;
        }
        public static int factDigit(BigInteger n)
        {
            int[] digits = n.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            int num = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                num += digits[i];
            }
            return num;
        }
    }
}
