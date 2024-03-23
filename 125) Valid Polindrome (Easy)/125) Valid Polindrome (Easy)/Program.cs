using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125__Valid_Polindrome__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "0P";
            Console.WriteLine(IsPolindrome(text));

        }
        public static string Correct(string s)
        {
            string text="";
            for(int i=0;i<s.Length;i++)
            {
                char c = s[i];
                if(Char.IsLetter(c) || Char.IsNumber(c))
                {
                    text += c.ToString().ToLower();
                }
            }
            return text;
        }
        public static bool IsPolindrome(string s)
        {
            int count = 0;
            s = Correct(s);
            for(int i=0;i<s.Length/2;i++)
            {
                if (s[i] == s[s.Length-i-1])
                {
                    count++; 
                }
            }
            if(count==s.Length/2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
