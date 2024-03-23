using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _268__Missing_Number__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ilkin";
            string t = "aa";
            s = s.Remove(0, 1);
            Console.WriteLine(s);
            Console.WriteLine(s.Remove(0,1));
            // Console.WriteLine(FindDifference(s,t));
        }

        public static char FindDifference(string s,string t)
        {
            int lent = t.Length;
           // char[]array=t.ToCharArray();
          //  HashSet<char> result = new HashSet<char>(s);
            List<char> list = new List<char>(s);
            List<char> list2 = new List<char>(t);
            for (int i = 0; i <lent; i++)
            {
                if (!list.Contains(list2[i]))
                {
                    return list2[i];
                }
                else
                {
                   list.Remove(list2[i]);
                    
                }
            }

            //string s = "abcd";
            //string t = "abcde";
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            return  ' ';
        }
    }
}
