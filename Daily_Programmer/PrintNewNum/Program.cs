using System;

namespace sumOfIntVal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an int value: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(invoke(num));
        }
        public static String invoke(int n)
        {
            if (n < 0) n = -n;  //In case of negative integers
            int temp = 0;
            int len = n.ToString().Length;
            int[] sep = new int[len];
            int counter = len;

            while (n > 0) {
                counter--;
                temp = (n % 10) + 1;
                sep[counter] = temp;
                n = n / 10;
            }
            String res = string.Join("", sep);
            return res;
        }
    }
}
