using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Word_4_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before");
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
            int c = 0;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After");
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");

        }
    }
}
