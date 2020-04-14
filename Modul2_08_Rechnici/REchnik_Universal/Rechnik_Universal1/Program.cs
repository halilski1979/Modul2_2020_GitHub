using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnik_Universal1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> rechnik = new Dictionary<string, int>();

            Console.Write("BrElRechnika=");
            int br = int.Parse(Console.ReadLine());

            //Вход на елементи на речник
            for (int i = 0; i < br; i++)
            {
                var linia = Console.ReadLine().Split(' ').ToList();
                string name = linia[0];
                int money    = int.Parse(linia[1]);
                if (rechnik.ContainsKey(name))
                    rechnik[name] = money;
                  //rechnik[name] += money;    Това увеличава парите на name
                else
                    rechnik.Add(name, money);
            }

            // Печат на речник
            foreach (var item in rechnik)
            {
                Console.WriteLine($"Ime: {item.Key}: {item.Value} leva");
            }

            //Сортиране по ключ
            Console.WriteLine("Сортиране по ключ");
            rechnik=rechnik.OrderBy(x => x.Key).ToDictionary(x=>x.Key,x=>x.Value);
            foreach (var item in rechnik)
            {
                Console.WriteLine($"Ime: {item.Key}: {item.Value}");
            }

            //Сортиране по ключ(низходящо)
            Console.WriteLine("Сортиране по ключ(низходящо)");
            rechnik = rechnik.OrderByDescending(x => x.Key).ThenBy(x=>x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in rechnik)
            {
                Console.WriteLine($"Ime: {item.Key}: {item.Value}");
            }

            //Сортиране по ключ чрез списък
            Console.WriteLine("Сортиране по ключ чрез списък");
            var spisak = rechnik.Keys.ToList();
            spisak.Sort();
            foreach (var item in spisak)
            {
                Console.WriteLine($"{item}: {rechnik[item]}");
            }


            //Сортиране по стойност
            Console.WriteLine("Сортиране по ключ");
            rechnik = rechnik.OrderBy(x => x.Value).ToDictionary(x=>x.Key,x=>x.Value);

            foreach (var item in rechnik)
            {
                Console.WriteLine($"Ime: {item.Key}: {item.Value}");
            }


            Console.Write("Ime za itrivane ot rechnika: ");
            string imeIztr = Console.ReadLine();

            //Изтриване по ключ от речник
            rechnik.Remove(imeIztr);
            
            
            foreach (var item in rechnik)
            {
                Console.WriteLine($"Ime: {item.Key}: {item.Value}");
            }

        }
    }
}
