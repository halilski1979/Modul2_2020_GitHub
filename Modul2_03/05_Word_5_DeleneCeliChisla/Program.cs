using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Word_5_DeleneCeliChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < br; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int ost = a % b;
                sum += ost;
            }
            Console.WriteLine(sum);
        }
    }
}
