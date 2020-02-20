using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Word_5_SumObarnatiChisla
{
    class Program
    {
        static void Main(string[] args)
        {

            // Обръщане на числата в списък и намиране на сумата им
            var list = Console.ReadLine().Split(' ').ToList();
            for (int i = 0; i < list.Count(); i++)
            {
                list[i] = String.Join("",list[i].Reverse());
            }
            int sum = list.Select(int.Parse).Sum();
            Console.WriteLine(sum);

            // Обръщане на string-елементи в списък и отпечатването им
            var listString = Console.ReadLine().Split(' ').ToList();
            for (int i = 0; i < listString.Count(); i++)
            {
                listString[i] = String.Join("", listString[i].Reverse());
            }
            Console.WriteLine(string.Join(" ",listString));
        }
    }
}
