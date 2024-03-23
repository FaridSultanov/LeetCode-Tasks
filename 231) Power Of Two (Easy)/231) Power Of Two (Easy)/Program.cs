using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _231__Power_Of_Two__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfTwo(256));
        }

        public static bool IsPowerOfTwo(int n)
        {

            int count=0;
           
            while(true)
            {
                if(Math.Pow(2,count)==n)
                {
                    return true;
                }
                else if(Math.Pow(2,count)>n)
                {
                    return false;
                }
                else
                {
                    count++;
                }
                

            }
        }
    }
}
