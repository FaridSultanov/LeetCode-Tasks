using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49__Rotate_Image__Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] array = {
                   new int[] {5, 1, 9, 1},
                   new int[] {2, 4, 8, 10},
                   new int[] {13, 3, 6, 7},
                    new int[] {15, 14, 12, 16}
};

            RotateImage(array);
        }

        public static void RotateImage(int[][]matrix)
        {
            int row=matrix.GetLength(0);
            int col=matrix.GetLength(1);
           // int[,]array= new int[row,col];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1)-1; j>=0; j--)
                {
                    Console.Write(matrix[j][i]+" ");
                }
                Console.WriteLine();
            }

            //for (int i = 0; i < col; i++)
            //{
            //    for (int j =0; j <row; j++)
            //    {
            //        Console.WriteLine(array[j,i]+" ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
