using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___Merge_Two_Sorted_List__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3,2,2,3 };
            int value = 3;
            Console.WriteLine(RemoveElement(array,value));

        }

        public static int RemoveElement(int[]nums,int val)
        {
            int[] array = new int[nums.Length];
            int count = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if (nums[i]!=val)
                {
                    array[count] = nums[i];
                    count++;
                }
            }
            Console.Write("[");
            for(int i=0;i<count;i++)
            {
                Console.Write(array[i]);
                if(i<array.Length-3)
                {
                    Console.Write(",");
                }

            }
            Console.Write("]");


            
            return count;

        }

    }
}
