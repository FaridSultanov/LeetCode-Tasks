using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79__Word_Search__Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char [][] array = { { 'A', 'B', 'C' }, { 'D', 'E', 'K' } };
            char[][] array = new char[][]
            {
                new char[] { 'A', 'B', 'C' },
                 new char[] { 'D', 'E', 'K' },
                
            };
         
            Exist(array, "string");
        }

        public static bool Exist(char[][]board,string word)
        {
            int[]array= new int[word.Length];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i][j] + " ");
                }
                Console.WriteLine();
            }

            
            return false;
        }
    }
}
