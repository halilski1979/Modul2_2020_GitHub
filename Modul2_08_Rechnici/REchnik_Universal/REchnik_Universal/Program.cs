using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REchnik_Universal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> city = new Dictionary<string, int>();
            

            

            while (true)
            {
                //Console.WriteLine("Vavedete na edin red: [команда] [Име на град] [Население]");
                //Console.WriteLine("Koманди: 1=>Спира входа на елементи");
                //Console.WriteLine("Koманди: 2=>Добавя град и население");
                //Console.WriteLine("Koманди: 3=>Отпечатва всички градове и населението");
                var linia = Console.ReadLine().Split(' ').ToList();
                string command = linia[0];
                
                if (command=="stop")
                {
                    break;
                }

                if (command == "print")
                {
                    string nameCity = linia[1];
                    if (city.ContainsKey(nameCity))
                    {
                        Console.WriteLine($"Град:{nameCity} => Население: {city[nameCity]}");
                    }
                        
                    
                }

                if (command=="add")
                {
                    string nameCity = linia[1];
                    int valueCity = int.Parse(linia[2]);
                    if (city.ContainsKey(nameCity))
                    {
                        city[nameCity] = valueCity;
                    }
                    else
                    {
                        city.Add(nameCity,valueCity);
                    }
                }
               
                
                
                //linia = Console.ReadLine().Split(' ').ToList();
                
            }
        }
    }
}
