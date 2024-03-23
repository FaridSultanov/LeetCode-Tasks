using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _189__Rotate_Array__Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2};
            RotateArray(array, 3);
        }

        public static void RotateArray(int[]nums,int k)
        {
           int f=k%(nums.Length);
           
                List<int> list = new List<int>();
                for (int i = nums.Length - f; i < nums.Length; i++)
                {
                    list.Add(nums[i]);
                }
                for (int i = 0; i < nums.Length - f; i++)
                {
                    list.Add(nums[i]);
                }

                Array.Clear(nums, 0, nums.Length);
                for (int i = 0; i < list.Count; i++)
                {
                    nums[i] = list[i];
                }

                foreach (var item in nums)
                {
                    Console.WriteLine(item);
                }
            
           
        }
    }
}
