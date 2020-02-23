using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnik_All
{
    class Program
    {
        static void Main(string[] args)
        {
            var rechnik = new SortedDictionary<string, int>() { ["Asen"] = 100, ["Ivan"] = 45, ["Petar"] = 33 };
       

            var person = new Dictionary<string, string>();
            person["ime1"] = "1";
            person["ime2"] = "2";
            person["ime3"] = "3";

            Console.WriteLine(string.Join(" ",person.Keys ));
            Console.WriteLine(string.Join(" ", person.Values));
            Console.WriteLine(string.Join(" ", person));

            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }

            Console.WriteLine();
           
            foreach (var item in person.Reverse())
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }

            //int stIme1 = person.["ime1"];
            //Console.WriteLine(stIme1);
        }
    }
}
