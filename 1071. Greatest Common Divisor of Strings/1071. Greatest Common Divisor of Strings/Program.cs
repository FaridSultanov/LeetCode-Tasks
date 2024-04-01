using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1071.Greatest_Common_Divisor_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ss = "    the sky is blue      ";
            Console.WriteLine(ReverseWords(ss));
        }


        public  static string ReverseWords(string s)
        {
            int left = 0;
            int right = s.Length - 1;

            
            while (left <= right && s[left] == ' ')
            {
                left++;
            }

            
            while (right >= left && s[right] == ' ')
            {
                right--;
            }

            
            if (left > right)
            {
                return "";
            }

            string ss= s.Substring(left, right - left + 1);
            string[]array=ss.Split(' ');

            //for(int i=0;i<array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            string k = "";
            for (int i = array.Length - 1; i >= 0; i--)
            {
                k += array[i];
                if(i!=0)
                {
                    k+= " ";
                }
            }
            return k;
        }
    }
}

