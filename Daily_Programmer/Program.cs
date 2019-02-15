using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace regexpress
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing filter method
            String example = "example";
            String example2 = "Llama";
            Console.WriteLine(filter(example));
            Console.WriteLine(filter(example2));
            //testing specialCharacter method
            String specEx = "$money";
            String specEx2 = "FIRE*";
            Console.WriteLine(specialCharacter(example));
            Console.WriteLine(specialCharacter(specEx));
            Console.WriteLine(specialCharacter(specEx2));

        }
        public static Boolean filter(String str)
        {
            //Finds pattern "ex" and returns true if contained in str
            Boolean y;
            var regexItem = new Regex(".*ex");
            if (regexItem.IsMatch(str))
                y = true;
            else
                y = false;
            return y;
        }
        public static Boolean specialCharacter(String str)
        {
            //Finds any special characters and returns true if contained in str
            Boolean y;
            var regexItem = new Regex("[^a-z0-9]");
            if (regexItem.IsMatch(str))
                y = true;
            else
                y = false;
            return y;
        }

    }
}
