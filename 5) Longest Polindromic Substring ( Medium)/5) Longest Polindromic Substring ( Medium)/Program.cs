using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _5__Longest_Polindromic_Substring___Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            s=Console.ReadLine();
            Console.WriteLine(LongestPolindrome(s));

        }
        public static bool IsPolindrome(string s)
        {
            int len = s.Length;
            int count = 0;
            for (int i = 0; i < len/2; i++)
            {
                if (s[i] == s[len - i - 1])

                {
                    count++;
                }
            }

            if(count==len/2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
     
        public static string LongestPolindrome(string s)
        {
            int len= s.Length;
            while(len!=0)
            {
                if(IsPolindrome(s))
                {
                    return s;
                }
                else
                {
                    len--;
                    s = s.Substring(0, len);
                }
            }
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            String text = new String(array);
            int len2 = text.Length;
            while(len2!=0)
            {
                if(IsPolindrome(text))
                {
                    return text;
                }
                else
                {
                    len2--;
                    text = text.Substring(0, len2);

                }
            }

            return " ";
        }
    }
}
