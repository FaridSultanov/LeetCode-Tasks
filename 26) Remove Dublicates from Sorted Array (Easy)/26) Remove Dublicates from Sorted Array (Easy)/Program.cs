using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26__Remove_Dublicates_from_Sorted_Array__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 2, 3, 4, 5, 6, 6, 3, };
            Console.WriteLine(RemoveDublicates(array));
        }

        public static int RemoveDublicates(int[]nums)
        {
            int count = 0;
            List<int> list = new List<int>(nums);
            List<int> result = new List<int>();
            result=list.Distinct().ToList();
            Array.Clear(nums,0,nums.Length);
            for(int i=0;i<result.Count();i++)
            {
                nums[i] = result[i];
                count++;
               

            }

            for(int j=0;j<nums.Length;j++)
            {
                Console.WriteLine(nums[j]);
            }
            return count;
        }
    }
}
