using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58__Length_of_Last_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ab  ";
            Console.WriteLine(LengthofLastWord(s));
        }

        public static int LengthofLastWord(string s)
        {
            int count = 0, index = s.Length - 1;
            while (count < s.Length)
            {
                if (s[index] == ' ')
                {
                    index--;
                }
                else if (s[index] != ' ')
                {
                    count++;
                    if (index == 0)
                    {
                        break;
                    }
                    else if (s[index - 1] == ' ' || s[index - 1] == null)
                    {
                        break;
                    }
                    else
                    {
                        index--;
                    }

                }
                else
                {
                    index--;
                }


                // if(index<0)
                // {
                //     break;
                // }
            }
            return count;
        }
    }
}
