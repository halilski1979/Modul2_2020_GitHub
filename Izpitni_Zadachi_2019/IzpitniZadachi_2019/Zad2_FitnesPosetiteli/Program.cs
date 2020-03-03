using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2_FitnesPosetiteli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> visitors = Console.ReadLine().Split(new char[] { ',' },
StringSplitOptions.RemoveEmptyEntries).ToList();
            string comand = Console.ReadLine();
            while (true)
            {
               
                if (comand=="END")
                {
                    break;
                }
                if (comand=="Add visitor")
                {
                   var name = Console.ReadLine();
                    visitors.Add(name);
                }

                if (comand=="Remove visitor on position")
                {
                    var pos = int.Parse(Console.ReadLine());
                    visitors.RemoveAt(pos);
                }

                if (comand == "Add visitor on position")
                {
                    var name = Console.ReadLine();
                    var pos = int.Parse(Console.ReadLine());
                    visitors.Insert(pos,name);
                }
                if (comand == "Remove visitor on position")
                {
                    var pos = int.Parse(Console.ReadLine());
                    visitors.RemoveAt(pos);
                }
                if (comand == "Remove last visitor")
                {
                    visitors.RemoveAt(visitors.Count-1);
                }
                if (comand == "Remove first visitor")
                {
                    visitors.RemoveAt(0);
                }
                comand = Console.ReadLine();

            }

            Console.WriteLine(string.Join(", ", visitors));

        }
    }
}
