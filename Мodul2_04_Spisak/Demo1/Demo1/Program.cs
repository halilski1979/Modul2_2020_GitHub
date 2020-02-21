using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> spisak = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ",spisak));
                           

            int number = spisak[spisak.Count() - 1];
            Console.WriteLine($"number={number}");

           
                while (spisak.Contains(number))
                {
                    spisak.Remove(number);
                }
           
            Console.WriteLine(string.Join(" ", spisak));
        }
    }
}
