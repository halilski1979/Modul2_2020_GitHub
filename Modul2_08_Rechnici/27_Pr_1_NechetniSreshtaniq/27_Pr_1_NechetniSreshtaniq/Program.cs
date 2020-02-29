using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Pr_1_NechetniSreshtaniq
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine().ToLower();
            //string[] words = input.Split(' ');
            string[] words = Console.ReadLine().ToLower().Split(' ');
            var counts = new Dictionary<string, int>();

            foreach (var item in words)
                if (counts.ContainsKey(item))
                    counts[item]++;
                else counts[item] = 1;

            var results = new List<string>();

            foreach (var item in counts)
                if (item.Value%2!=0)
                {
                    results.Add(item.Key);
                }
                // TODO: добави pair.Key към резултатите ако pair.Value е нечетно
                Console.WriteLine(string.Join(", ", results));

        }
    }
}
