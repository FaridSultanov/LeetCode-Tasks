using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _349__Intersection_of_Two__Array__Easy_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 89,85,86,88,82,91 };
            int[] array1 = { 98,92,86,94,91,88};
            Console.WriteLine(Intersection(array,array1));
        }

        public static int[] Intersection(int[]nums1,int[]nums2)
        {
            List<int> numbers = new List<int>();
            for(int i=0;i<nums1.Length;i++)
            {
                numbers.Add(nums1[i]);
            }
            List<int> DNumbers = new List<int>();
            DNumbers=numbers.Distinct().ToList();

            int[]array= new int[DNumbers.Count];    
            for(int i=0;i<array.Length;i++)
            {
                array[i] = DNumbers[i];
            }

            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            for(int i=0;i<nums2.Length;i++)
            {
                list.Add(nums2[i]);
            }

            list2=list.Distinct().ToList();
            int[]array2=new int[list2.Count];
            for(int i=0;i<array2.Length;i++)
            {
                array2[i] = list2[i];
            }

            List<int> list3 = new List<int>();
            if(array.Length>=array2.Length)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        if (array[i] == array2[j])
                        {
                            list3.Add(array[i]);
                        }
                    }
                }
            }

            else
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    for (int j = 0; j < array.Length; j++)
                    {
                        if (array2[i] == array[j])
                        {
                            list3.Add(array2[i]);
                        }
                    }
                }
            }
            int[]arr= new int[list3.Count];
            for(int i=0;i < arr.Length;i++)
            {
                arr[i] = list3[i];
            }
          //-----------------------------------------------------------------------------------
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            return arr;

        }
    }
}
