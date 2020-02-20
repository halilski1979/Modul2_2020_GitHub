using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_word_2_VmakvaneElementSortMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Array.Sort(nums);
            Console.WriteLine(string.Join(" ",nums));

            Console.Write("Изберете числото, което искате да вмъкнете в сортираният масив: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"number={number}");
            int[] nums1 = new int[nums.Length+1];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]<number)
                {
                    nums1[i] = nums[i];
                }
                else if (number>nums[i] && number<nums[i+1])
                {
                    nums1[i] = number;
                }
                else
                {
                    nums1[i + 1] = nums[i];
                }
                //Console.WriteLine($"number={number}");
            }

            Console.WriteLine(string.Join(" ",nums1));
            Console.ReadKey();

        }
    }
}
