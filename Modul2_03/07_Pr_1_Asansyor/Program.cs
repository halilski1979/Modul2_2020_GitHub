using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Pr_1_Asansyor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int course = n / p;
            int course1 = n % p;
            if (course1>0)
            {
                course++;
            }
            Console.WriteLine(course);
        }
    }
}
