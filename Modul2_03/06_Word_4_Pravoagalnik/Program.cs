﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Word_4_Pravoagalnik
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double P = 2 * a + 2 * b;
            double S = a * b;
            decimal d = (decimal)Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(P);
            Console.WriteLine(S);
            Console.WriteLine(d);
        }
    }
}
