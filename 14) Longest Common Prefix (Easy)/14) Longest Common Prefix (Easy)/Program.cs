using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _14__Longest_Common_Prefix__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Geek","Gee","Geekfor","GeeekkkfforrGreeks" };
            Console.WriteLine(LongestCommonPrefix(array));
        }


        public static string LongestCommonPrefix(string[]strs)
        {

            string value = strs[0];
            int len = value.Length;
            for(int i=1;i<strs.Length;i++)
            {
                while (strs[i].IndexOf(value)!=0)
                {
                    value = value.Substring(0, len - 1);
                    len--;

                    if(len==0)
                    {
                        return "";
                    }
                }
            }

            return  value;

        }
    }
}
