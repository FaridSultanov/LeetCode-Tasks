using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2481__Find_the_Piwot_Integer__Esay_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindThePiwotInteger(1));
        }

        public static int FindThePiwotInteger(int n)
        {
            int[] array = new int[n];
            for(int i=0;i<n;i++)
            {
                array[i] =i+1;
            }

            int leftsum = 0;
           
            int sum = array.Sum();
            for(int i=0;i<n;i++)
            {
                leftsum += array[i];
                if (sum - leftsum + array[i] ==leftsum)
                {
                    return array[i];
                }
                
            }

            
            return -1;

        }
    }
}
