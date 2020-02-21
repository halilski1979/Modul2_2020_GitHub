using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Pr_2_RemoveNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> spisak = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < spisak.Count; i++)
            {
                if (spisak[i]<0)
                {
                    spisak.Remove(spisak[i]);
                }
            }
            Console.WriteLine(string.Join(" ", spisak));




        }
    }
}
