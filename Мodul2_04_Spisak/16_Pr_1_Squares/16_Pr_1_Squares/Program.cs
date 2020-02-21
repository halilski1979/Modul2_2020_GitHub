using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Pr_1_Squares
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            numbers.Reverse();
            List<int> squares = new List<int>();
            foreach (var item in numbers)
            {
                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    squares.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", squares));

        }
    }
}
