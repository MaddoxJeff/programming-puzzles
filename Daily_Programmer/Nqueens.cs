using System;

namespace ConsoleApp3
{
    class Nqueens {
        static void Main(string[] args) {
            int[] boardLayout = new int[] { 4, 3, 1, 8, 1, 3, 5, 2 };

            for(int i = 0; i < boardLayout.Length; i++) {
                for(int k = i+1; k < boardLayout.Length; k++){
                    if (boardLayout[i]-boardLayout[k]==(k+1)-(i+1)) {
                        Console.WriteLine("Diagonal intersection on " + (conv(i + 1)) + "," + boardLayout[i] + " and " + (conv(k + 1)) + "," + boardLayout[k]);
                    }
                }
            }
            for (int index = 0; index < boardLayout.Length; index++) {
                for (int j = index+1; j < boardLayout.Length; j++){
                    if (boardLayout[index] == (boardLayout[j])){
                        Console.WriteLine("Horizontal intersection on row" + boardLayout[index]);
                    }
                }
            }
        }
        public static String conv(int n)  {
            Char c = (Char)((97) + (n - 1));
            return c.ToString();
        }
    }
}