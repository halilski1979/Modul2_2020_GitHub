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
            Dictionary<string, string> person = new Dictionary<string, string>();
            var person1 = new Dictionary<string, int>();

            person.Add("name1","one");
            person.Add("name2","two");
            person.Add("name3","three");

            person1.Add("Ime1",1);
            person1.Add("Ime2",2);
            person1.Add("Ime3",3);

            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key} =>{item.Value}");
            }

            foreach (var item in person1)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }


        }
    }
}
