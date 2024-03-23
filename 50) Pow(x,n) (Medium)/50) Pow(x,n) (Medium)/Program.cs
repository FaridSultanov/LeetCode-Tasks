using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50__Pow_x_n___Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine(MyPow(2.1,3));

        }

        public static double MyPow(double x, int n)
        {
            double sum = Math.Pow(x, n);

            string text = sum.ToString();
            int a = text.IndexOf(".");
            int len = (text.Substring(a + 1).Length);
            for (int i = 0; i < 5 - len; i++)
            {
                text += "0";
            }

            double value = double.Parse(text);

            return value;







        }
    }
}
