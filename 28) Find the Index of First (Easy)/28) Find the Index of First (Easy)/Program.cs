using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28__Find_the_Index_of_First__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            array=array.Reverse().ToArray();
            for(int i=0;i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            
        }

       
    }
}
