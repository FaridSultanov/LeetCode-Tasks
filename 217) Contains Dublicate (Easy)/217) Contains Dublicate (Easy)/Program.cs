using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217__Contains_Dublicate__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(ContainsDublicate(array));
        }
      
        public static bool ContainsDublicate(int[] nums)
        {
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            for(int i=0;i<nums.Length;i++)
            {
                list.Add(nums[i]);
            }
            list2=list.Distinct().ToList();
            if(list.Count==list2.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        //public static bool ContainsDublicate(int[] nums)
        //{
        //    int count = 0;
        //    string text = "";
        //    for(int i=0;i<nums.Length; i++)
        //    {
        //        text += nums[i].ToString();
        //    }
        //    string k=text;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (text.IndexOf(text.Substring(i+1)) != null)
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine(k) ;
        //    if (count != 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
