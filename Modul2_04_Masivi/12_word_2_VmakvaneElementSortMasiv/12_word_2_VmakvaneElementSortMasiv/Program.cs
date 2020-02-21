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

            int[] sortedArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           // Array.Sort(sortedArr);
            Console.WriteLine(string.Join(" ", sortedArr));

            Console.Write("Изберете числото, което искате да вмъкнете в сортираният масив: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"number={number}");
            int[] newArr = new int[sortedArr.Length + 1];

            if (number <= sortedArr[0])
            {
                newArr[0] = number;
                for (int i = 1; i < newArr.Length; i++)
                {
                    newArr[i] = sortedArr[i - 1];
                }
            }
            else if (number >= sortedArr[sortedArr.Length - 1])
            {
                newArr[newArr.Length - 1] = number;
                for (int i = 0; i < newArr.Length - 1; i++)
                {
                    newArr[i] = sortedArr[i];
                }
            }
            else
            {
                int j = 0;
                for (int i = 0; i < newArr.Length; i++)
                {
                    if (number >= sortedArr[i])
                    {
                        newArr[i] = sortedArr[j];
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
                newArr[j] = number;
                for (int i = j + 1; i < newArr.Length; i++)
                {
                    newArr[i] = sortedArr[i - 1];
                }
            }

            Console.WriteLine(string.Join(" ", newArr));
            Console.ReadKey();

        }
    }
}
