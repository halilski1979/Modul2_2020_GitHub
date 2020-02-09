using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Pr_1_ChetniChsila
{
    class Program
    {
        static void Main(string[] args)
        {
            var spisak = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            // I начин
            for (int i = 0; i < spisak.Count; i++)
            {
                if (spisak[i] % 2 == 0)
                {
                    Console.WriteLine(spisak[i]);
                }
            }
            Console.WriteLine("-------------------------");

            // II начин
            Console.WriteLine(string.Join("|", spisak.Where(x => x % 2 == 0)));


            Console.WriteLine("-------------------------");
            // III  начин
            foreach (var item in spisak)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
