using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _169__Majority_Element__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3,3,4,4,4};

            Console.WriteLine(MajorityElement(array));
           

            

            //   Console.WriteLine(MajorityElement(array));
        }

        public static int MajorityElement(int[]nums)
        {
            if (nums == null)
            {
                return -1;
            }
            else
            {
                var maxCount = nums.GroupBy(x => x)
                           .Max(g => g.Count());

                var maxElements = nums.GroupBy(x => x)
                                   .Where(g => g.Count() == maxCount)
                                   .Select(g => g.Key);

                return maxElements.Sum();
            }

            
        }
    }
}
