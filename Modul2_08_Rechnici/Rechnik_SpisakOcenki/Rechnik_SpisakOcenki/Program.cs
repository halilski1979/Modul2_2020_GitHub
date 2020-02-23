using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnik_SpisakOcenki
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> persons = new Dictionary<string, List<int>>();
            Console.WriteLine("Broy uchenici: ");
            int brUch = int.Parse(Console.ReadLine());

            for (int i = 0; i < brUch; i++)
            {
                Console.WriteLine("Ime na uchenik");
                string ime = Console.ReadLine();

                List<int> ocenki = new List<int>();
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ocenka[{j}]: ");
                    ocenki.Add(int.Parse(Console.ReadLine()));
                }
                persons.Add(ime,ocenki);
            }
            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Key} => {string.Join(" ",item.Value)}");
            }

        }
    }
}
