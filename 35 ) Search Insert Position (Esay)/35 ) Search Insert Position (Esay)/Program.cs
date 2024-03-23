using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35___Search_Insert_Position__Esay_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 4, 6, 10, 13, 17, 21 };
            int target = 9;
            Console.WriteLine(SearchInsert(array,target));
        }


        public static int SearchInsert(int[]nums,int target)
        {
            int count = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if (target == nums[i])
                {
                    return i;
                }
                else if (target > nums[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
