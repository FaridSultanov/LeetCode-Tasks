using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66___Plus_One__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9,8,7,6,5,4,3,2,1,0};
             Console.WriteLine(PlusOne(array));
           
        }

        public static int[] PlusOne(int[] digits)
        {
            ulong sum = 0;
            int count = 0;
            for(int i= digits.Length-1; i>=0;i--)
            {
                sum += (ulong)(digits[i] * Math.Pow(10, count));
                count++;
            }
            int[] array2 = new int[0];

            ulong cem = sum+1;
            int c = 0;
            while(cem!=0)
            {
                c++;
                Array.Resize(ref array2, c);
                array2[c - 1] =(int) cem % 10;
                cem = cem / 10;
            }
            array2 = array2.Reverse().ToArray();
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            Console.WriteLine();
            return array2;
        }
    }
}
