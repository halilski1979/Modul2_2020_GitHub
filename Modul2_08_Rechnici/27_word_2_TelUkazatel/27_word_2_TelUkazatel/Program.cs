using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_word_2_TelUkazatel
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = new Dictionary<string, string>();
           
            while (true)
            {
                var list = Console.ReadLine().Split();

                switch (list[0])
                {
                    // Добавяне на запис в речника
                    case "A":
                        {
                            phoneNumbers.Add(list[1], list[2]);
                            break;  
                         }

                    // Търсене на запис в речника
                    case "S":
                        {
                            if (phoneNumbers.ContainsKey(list[1])) Console.WriteLine("{0} -> {1}", list[1], phoneNumbers[list[1]]);
                            else Console.WriteLine("Contact {0} does not exist.", list[1]);
                            break;
                        }

                    case "END": { return; }
                       


                };


                


            }

        }
    }
}
