using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace conwaysGameOfLife
{
    class Program
    {
        static void Main(String[] args)
        {
            String input = File.ReadAllText(@"C:\Users\Jeff\Documents\lifeBoard.txt");
            int i = 0, j = 0;
            int[,] board = new int[16, 16];
            int[,] tempBoard = new int[16, 16];
            char[,] boardEvolve = new char[15, 15];
            int n = 0;
            int m = 0;

            foreach (var row in input.Split('\n'))
            {
                j = 0;
                foreach (var col in row.Trim().Split(' '))
                {
                    board[i, j] = int.Parse(col.Trim());
                    j++;
                }
                i++;
            }

            int[,] baseCase = board;
            char[,] baseCaseEvolve = loopChar(baseCase);
            printBoard(baseCaseEvolve);
            for (int k = 0; k < 10; k++)
            {
                Console.Clear();
                tempBoard = loop(board);
                boardEvolve = loopChar(board);
                printBoard(boardEvolve);
                board = tempBoard;
            }

        }
        public static char dCheckNeighbor(int[,] board, int n, int m)
        {
            if (n == 0 || n == 15)
                return '.';

            int counter = 0;
            int i = m - 1;
            int alive = 0;
            int dead = 0;
            char c = ' ';
            while (counter < 3)
            {
                //left side
                if (board[(n - 1), i] == 0)
                    dead++;
                else
                    alive++;
                //right side
                if (board[(n + 1), i] == 0)
                    dead++;
                else
                    alive++;
                //middle
                if (board[n, i] == 0)
                    dead++;
                else
                    alive++;
                i++;
                counter++;
            }
            if (alive == 3)
                c = '*';
            else
                c = '.';
            return c;
        }
        public static char aCheckNeighbor(int[,] board, int n, int m)
        {
            if (n == 0 || m == 0)
                return '.';
            if (n == 1)
                return '.';
            //[n,m]
            int counter = 0;
            int i = m - 1;
            int alive = 0;
            int dead = 0;
            char c = ' ';
            while(counter < 3)
            {
                //left side
                if (board[(n - 1), i] == 0)
                    dead++;
                else
                    alive++;
                //right side
                if (board[(n + 1), i] == 0)
                    dead++;
                else
                    alive++;
                //middle
                if (board[n, i] == 0)
                    dead++;
                else
                    alive++;
                i++;
                counter++;
            }
            //take care of middle
            if (board[n, m] == 0)
                dead--;
            else
                alive--;
            //
            if (alive == 1)
                c = '.';
            if (alive == 2 || alive == 3)
                c = '*';
            if (alive > 3)
                c = '.';
             return c;
            //return alive;
        }

        public static int [,] loop (int[,] board)
        {
            char[,] boardEvolve = new char[16, 16];
            int[,] tempBoard = new int[16, 16];
            for (int k = 0; k < 16; k++)
            {
                for (int p = 0; p < 16; p++)
                {

                    if (p == 0 || p == 15)
                    {
                        boardEvolve[k, p] = '.';
                        tempBoard[k, p] = 0;
                        continue;
                    }
                    if (board[k, p] == 1)
                    {
                        boardEvolve[k, p] = aCheckNeighbor(board, k, p);
                        if (boardEvolve[k, p] == '*')
                            tempBoard[k, p] = 1;
                        else
                            tempBoard[k, p] = 0;
                    }
                    if (board[k, p] == 0)
                    {
                        boardEvolve[k, p] = dCheckNeighbor(board, k, p);
                        if (boardEvolve[k, p] == '*')
                            tempBoard[k, p] = 1;
                        else
                            tempBoard[k, p] = 0;
                    }
                }
            }
            return tempBoard;
        }
        public static char[,] loopChar(int[,] board)
        {
            char[,] boardEvolve = new char[16, 16];
            for (int k = 0; k < 16; k++)
            {
                for (int p = 0; p < 16; p++)
                {

                    if (p == 0 || p == 15)
                    {
                        boardEvolve[k, p] = '.';
                        continue;
                    }
                    if (board[k, p] == 1)
                    {
                        boardEvolve[k, p] = aCheckNeighbor(board, k, p);
                    }
                    if (board[k, p] == 0)
                    {
                        boardEvolve[k, p] = dCheckNeighbor(board, k, p);
                    }
                }
            }
            return boardEvolve;
        }
        public static void printBoard(char [,] boardEvolve)
        {
            for (int k = 0; k < 16; k++)
            {
                for (int p = 0; p < 16; p++)
                {
                    Console.Write(boardEvolve[k, p] + " ");
                }
                Console.WriteLine("\r\n");
            }
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
        }
    }
}
