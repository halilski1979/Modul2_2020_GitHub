using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElements_Rechnik
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Dictionary<string, int>();
            var person1 = new Dictionary<string, int>();

            Console.Write("Broy na elementite: ");
            int br = int.Parse(Console.ReadLine());
            int j = 0;
            for (int i = 0; i < br; i++)
            {
                Console.Write("Ime: ");
                string ime = Console.ReadLine();
                Console.Write("Nomer: ");
                int nomer = int.Parse(Console.ReadLine());

                person.Add(ime, nomer);

            }

            while (j<br)
            {
                Console.Write("Ime: ");
                string ime = Console.ReadLine();
                Console.Write("Nomer: ");
                int nomer = int.Parse(Console.ReadLine());

                person.Add(ime, nomer);
                j++;
            }

            foreach (var item in person)
            {
                Console.WriteLine($"Ime:{item.Key} Nomer:{item.Value}");
            }

            foreach (var item in person1)
            {
                Console.WriteLine($"Ime:{item.Key} Nomer:{item.Value}");
            }


        }
    }
}
