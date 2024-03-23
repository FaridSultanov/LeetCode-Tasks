using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _11.Container_With_Most_Water__Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3,0,1,2,4 };
            Console.WriteLine(MaxArea(array));
        }

        public static int MaxArea(int[]height)
        {
            int l = 0, r = height.Length-1,sum=0,max=0;
            while(l<r)
            {
                sum = (r - l) * Math.Min(height[l], height[r]);
                max = Math.Max(sum, max);
                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return max ;
        }
    }
}

