using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121__Best_Time_To_Buy_and_Sell_Stock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(SellStock(array));

        }

        public static int SellStock(int[]prices)
        {
            int left = 0, right = prices.Length - 1;
            int max = 0;
            while(left<right)
            {
                int dif = prices[right] - prices[left];
                max=Math.Max(max, dif);
                if (prices[left + 1] < prices[left])
                {
                    left++;
                }
                else //(prices[right - 1] > prices[right])
                {
                    right--;
                }
                
            }
            return max;
        }
    }
}
