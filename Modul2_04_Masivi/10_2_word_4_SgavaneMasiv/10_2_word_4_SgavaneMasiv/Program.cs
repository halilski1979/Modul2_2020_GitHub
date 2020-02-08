using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_word_4_SgavaneMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int rowLeft = nums.Length / 4;
            int rowRight = nums.Length / 4;
            int rowMiddle = nums.Length / 2;

            Console.WriteLine($"rowLeft={rowLeft}");
            Console.WriteLine($"rowRight={rowRight}");
            Console.WriteLine($"rowMiddle={rowMiddle}");

            int[] numsLeft = new int[rowLeft];
            int[] numsRight = new int[rowRight];
            int[] numsMiddle = new int[rowMiddle];

            for (int i = 0; i < rowLeft; i++)
            {
                numsLeft[i] = nums[i];
            }
            Console.WriteLine(string.Join(" ", numsLeft));

            for (int i = 0; i < rowMiddle; i++)
            {
                numsMiddle[i] = nums[i + rowLeft];
            }
            Console.WriteLine(string.Join(" ", numsMiddle));

            for (int i = 0; i < rowRight; i++)
            {
                numsRight[i] = nums[rowLeft + rowMiddle + i];
            }
            Console.WriteLine(string.Join(" ", numsRight));

            numsLeft = numsLeft.Reverse().ToArray();
            numsRight = numsRight.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", numsLeft));
            Console.WriteLine(string.Join(" ", numsRight));

            int[] finalNums = new int[rowMiddle];
            for (int i = 0; i < rowMiddle; i++)
            {
                if (i < rowLeft)
                {
                    finalNums[i] = numsLeft[i] + numsMiddle[i];
                }
                if (i >= rowLeft && i < rowMiddle)
                {
                    finalNums[i] = numsRight[i - (rowRight / 2 + 1)] + numsMiddle[i];
                }

            }
            Console.WriteLine(string.Join(" ", finalNums));
        }
    }
}
