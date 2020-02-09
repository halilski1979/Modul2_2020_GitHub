using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Pr_2_SpisakKraynosti
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> spisak = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int min = spisak.Min();
            int max = spisak.Max();
            foreach (var item in spisak)
            {
                if (item == min)
                {
                    Console.Write(item + " ");
                }
            }

            foreach (var item in spisak)
            {
                if (item == max)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Varaiant 2");
            Console.Write(string.Join(" ",spisak.Where(x=>x==min)));
            Console.Write(" ");
            Console.Write(string.Join(" ", spisak.Where(x => x==max)));
            Console.WriteLine();
        }
    }
}
