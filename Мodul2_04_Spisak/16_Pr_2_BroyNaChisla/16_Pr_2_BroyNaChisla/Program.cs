﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Pr_2_BroyNaChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int m = nums.Max();
            Console.WriteLine(m);

            var counts = new int[nums.Max() + 1];
            foreach (var num in nums)
                counts[num]++;
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                    Console.WriteLine($"{i} -> {counts[i]}");
            }

        }
    }
}
