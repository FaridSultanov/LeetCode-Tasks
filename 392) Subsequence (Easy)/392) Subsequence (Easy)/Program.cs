using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _392__Subsequence__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4,5, 6 };
            Console.WriteLine(array[array.Length-1] - array[0]);
        }

        #region Subsequence
        //public static bool Subsequence(string s,string t)
        //{
        //    int sindex = 0, tindex = 0;
        //    while(sindex< s.Length && tindex<t.Length)
        //    {
        //        if (s[sindex] == t[tindex])
        //        {
        //            sindex++;
        //            tindex++;
        //        }
        //        else
        //        {
        //            tindex++;
        //        }
        //    }

        //    return sindex== s.Length;


        //}

        #endregion


        #region MaxProfit
        public static int MaxProfit(int[]prices)
        {
            int sumbuy = 0, sumsell = 0;
           // int left
            return 0;
        }
        #endregion
    }
}
