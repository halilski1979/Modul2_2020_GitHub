using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> person = new Dictionary<string, int>
            {
                { "Halil",11} ,
                { "Asen",222} ,
                { "Petar",444} ,
                { "Ivan",333} ,
                { "Petq",222} ,
                { "Stefan",222} ,
            };
            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            Console.WriteLine("=======Сортиран речник по ключ==============");

            //Първи начин за сортиране по ключ
            var result = person.OrderBy(x => x.Key).ThenBy(x => x.Value);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
            //Втори начин за сортиране по ключ
            //person = person.OrderBy(x => x.Key).ThenBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("=======Сортиран речник по ключ в низходящ ред==============");
            result = result.OrderByDescending(x=>x.Key);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }






        }
    }
}
