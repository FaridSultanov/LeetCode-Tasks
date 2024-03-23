using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80___Remove_Dublicates_from_Sorted_Array__Medium_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            
            Console.WriteLine(RemoveDublicates(array));
        }

        public static int RemoveDublicates(int[]nums)
        {
            // Eğer dizi boşsa veya null ise 0 döndür
            if (nums == null || nums.Length == 0)
                return 0;

            // Tekrarlanan sayı sayacı
            int count = 0;

            // Her bir sayının en fazla 2 kez tekrarlanmasını sağlamak için sonuç listesi
            List<int> result = new List<int>();

            // İlk sayıyı sonuç listesine ekle
            result.Add(nums[0]);

            // Tekrarlanan sayıları sayacak değişken
            int repeatCount = 1;

            // Dizideki her bir sayıyı kontrol et
            for (int i = 1; i < nums.Length; i++)
            {
                // Eğer şu anki sayı bir önceki sayıya eşitse
                if (nums[i] == nums[i - 1])
                {
                    // Tekrarlanan sayı sayacını artır
                    repeatCount++;

                    // Eğer bu tekrarlanan sayı sayısı 2'den küçükse, sonuç listesine ekle
                    if (repeatCount <= 2)
                    {
                        result.Add(nums[i]);
                    }
                }
                else
                {
                    // Eğer şu anki sayı bir önceki sayıdan farklıysa
                    // Tekrarlanan sayı sayacını sıfırla
                    repeatCount = 1;

                    // Şu anki sayıyı sonuç listesine ekle
                    result.Add(nums[i]);
                }
            }

            // Sonuç listesinin elemanlarını diziye kopyala
            result.CopyTo(nums);
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine();
            // Sonuç listesinin uzunluğunu döndür
            return result.Count;
        }
    }
}
