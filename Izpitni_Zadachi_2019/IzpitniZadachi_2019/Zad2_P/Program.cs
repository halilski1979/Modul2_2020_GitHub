using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _02_Fitness_Posetitely
{
    class Program
    {
        static void Main(string[] args)
        {
            var peoples = Console.ReadLine().Split(new char[] { ',' },
            StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = Console.ReadLine();
            while (command != "END")
            {
                if (command == "Add visitor")
                {
                    var name = Console.ReadLine();

                    peoples.Add(name);

                }
                if (command == "Add visitor on position")
                {
                    var name = Console.ReadLine();
                    var position = int.Parse(Console.ReadLine());
                    peoples.Insert(position, name);
                }
                if (command == "Remove visitor on position")
                {
                    var position = int.Parse(Console.ReadLine());
                    peoples.RemoveAt(position);
                }
                if (command == "Remove last visitor")
                {
                    peoples.RemoveAt(peoples.Count - 1);
                }
                if (command == "Remove first visitor")
                {
                    peoples.RemoveAt(0);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", peoples));
        }
    }
}
