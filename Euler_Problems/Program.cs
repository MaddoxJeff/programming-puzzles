using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace EulerProj18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Temp array to hold total values
            string line1 = File.ReadLines("C:\\Users\\Jeff\\Documents\\triangleData.txt").Skip(13).Take(1).First();
            int[] lineArray = line1.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            //First line array
            string starting = File.ReadLines("C:\\Users\\Jeff\\Documents\\triangleData.txt").Skip(14).Take(1).First();
            int[] startArr = starting.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            //Prints first two lines out
            Console.Write(string.Join("  ", startArr));
            Console.WriteLine("\r\n");
            Console.Write(string.Join("  ", lineArray));
            Console.WriteLine("\r\n");
            //k is a counter to keep track of which line you are on.
            int k = 14;
            while(k != 0)
            {
                //Inserts the bottom and top line in an array
                //The bottom array is only used during the base case
                //lineArray becomes the new bottom array after the first itteration
                string lineBottom = File.ReadLines("C:\\Users\\Jeff\\Documents\\triangleData.txt").Skip(k).Take(1).First();
                string lineTop = File.ReadLines("C:\\Users\\Jeff\\Documents\\triangleData.txt").Skip(k-1).Take(1).First();
                int[] arrBottom = lineBottom.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                int[] arrTop = lineTop.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
                //base case
                if(k == 14)
                {
                    for (int i = 0; i < arrTop.Length; i++)
                    {
                        if (arrTop[i] + arrBottom[i] > arrTop[i] + arrBottom[i + 1])
                            lineArray[i] += arrBottom[i];
                        else
                            lineArray[i] += arrBottom[i + 1];
                    }
                }
                
                if (k != 14)
                {
                    for (int i = 0; i < arrTop.Length; i++)
                    {
                        if (lineArray[i] + arrTop[i] > lineArray[i+1] + arrTop[i])
                            lineArray[i] += arrTop[i];
                        else
                            lineArray[i] = lineArray[i+1] + arrTop[i];
                    }
                }
                //Prints the new added lines
                for(int j = 0;j < k; j++)
                {
                    Console.Write(string.Join(" ", lineArray[j] + " "));
                }             
                Console.WriteLine("\r\n");
                k --;
            }
        }

    }
}
