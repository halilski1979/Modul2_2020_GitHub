using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_word_4_ObarnatSpisak
{
    class Program
    {
        static void Main(string[] args)
        {
            //UNDER CONSTRUCTION

            List<string> names = Console.ReadLine().Split(',').ToList();


            foreach (var name in names)
            {
                Console.WriteLine($" { string.Join(' ',name.Split(' ').Reverse()) }");
            }
            



           
        }
    }
}
