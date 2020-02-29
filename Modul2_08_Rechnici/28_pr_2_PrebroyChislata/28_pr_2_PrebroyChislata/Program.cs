using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_pr_2_PrebroyChislata
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var counts = new SortedDictionary<double, int>();


            foreach (var item in nums)
                if (counts.ContainsKey(item))
                    counts[item]++;
                else
                    counts[item] = 1;

            foreach (var num in counts.Keys)
                Console.WriteLine($"{num} -> {counts[num]}");

        }
    }
}
