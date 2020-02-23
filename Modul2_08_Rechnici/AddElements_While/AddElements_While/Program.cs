using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElements_While
{
    class Program
    {
        static void Main(string[] args)
        {
            var goldMiners = new Dictionary<string, int>();
            int s=0;
            while (true)
            {
                Console.Write("Izkopaemo:");
                string izkopaemo = Console.ReadLine();
                if (izkopaemo == "stop") break;

                Console.Write("StoynostIzkopaemo: ");
                int values = int.Parse(Console.ReadLine());
                goldMiners.Add(izkopaemo,values);
            }

            //Отпечатване на ключ и стойност
            foreach (var item in goldMiners)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            //Отпечатване само на ключ
            foreach (var item in goldMiners.Keys)
            {
                Console.WriteLine(item);
            }
            //Отпечатване само на стойност
            foreach (var item in goldMiners)
            {
                Console.WriteLine(item.Value);
            }
            //Намиране на сума на стойностите (int)
            foreach (var item in goldMiners)
            {
                s += item.Value; 
            }
            Console.WriteLine(s);
        }
    }
}
