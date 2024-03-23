using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _791___Custom_Sort_String__Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "hucw";
            string b = "utzoampdgkalexslxoqfkdjoczajxtuhqyxvlfatmptqdsochtdzgypsfkgqwbgqbcamdqnqztaqhqanirikahtmalzqjjxtqfnh";
            Console.WriteLine(CustomSortString(a,b));
        }

        public static string CustomSortString (string order, string s)
        {
            string count = "";
            int len = order.Length;
            int l = s.Length;
            for(int i=0;i<len;i++)
            {
                for(int j=0;j<l;j++)
                {
                    if (order[i] == s[j])
                    {
                        count += order[i];
                    }
                    
                }
            }
            string sum = "";
           
           
            for(int j=0;j<s.Length;j++)
            {
                if (!count.Contains(s[j]))
                {
                    sum += s[j];
                }
            }
           

            char[] charArray = sum.ToCharArray();
            Array.Sort(charArray);
            string sortedString = new string(charArray);
            return count+sortedString;
        }
    }
}
