using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;


namespace euler22
{
    class Program
    {    
        static void Main(string[] args)
        {
            //File into string
            string[] file = System.IO.File.ReadAllLines(@"C:\Users\Jeff\Documents\p022_names.txt");
            //splits each name into string array index
            //file[0].Split(',') removes the comma and inserts in index value
            //.Trim('"')removes the first and last character in the string
            string[] names = file[0].Split(',').Select(n => Convert.ToString(n).Trim('"')).ToArray();
            //sort string array
            Array.Sort(names, StringComparer.InvariantCulture);
            int total = 0;
            int nameScore = 0;
            for(int i = 0;i < names.Length; i++)
            {
                nameScore = stringToNumber(names[i]) * (i + 1);
                total += nameScore;
            }
            //test
            Console.WriteLine(total);
        }
        public static int stringToNumber(string str)
        {
            int res = 0;
            foreach (var c in str)
            {
                int d = c - 'A' + 1;
                res = res + d;
            }
            return res;
        }
    }
}
