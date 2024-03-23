using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _8.String_To_Integer__Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "words and 987";
            Console.WriteLine(MyAtoi(text));
        }

        public static int MyAtoi(string s)
        {
            string ss = "";
            for(int i=0;i<s.Length;i++)
            {
                char a = s[i];
                if(Char.IsDigit(a) || a=='-')
                {
                    ss += a;
                }
            }
            int k=int.Parse(ss);
            
            return k;
        }
    }
}
