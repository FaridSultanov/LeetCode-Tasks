using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _876___Middle_of_the_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avarage(1, -2, 3, -4, 6, -6, 7, -8);
        }


        public static void Avarage(params int[]arr)
        {
            double pluscem = 0, minuscem = 0;
            int countplus=0,countmenfi=0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]<0)
                {
                    pluscem += arr[i];
                    countplus++;
                    
                }
                else if (arr[i]>0)
                {
                    minuscem += arr[i];
                    countmenfi++;
                }
                
            }

            Console.WriteLine("Avarage plus : " + pluscem / countplus);
            Console.WriteLine("Avarage minus : " + minuscem / countmenfi);
        }

        


       

        

    }
}
