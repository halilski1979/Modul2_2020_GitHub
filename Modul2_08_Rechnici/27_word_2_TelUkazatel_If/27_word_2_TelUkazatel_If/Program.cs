using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_word_2_TelUkazatel_If
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = new Dictionary<string, string>();

           

                while (true)
                {
                    var list = Console.ReadLine().Split();
                    if (list[0]== "END")
                    {
                        break;
                    }
                    else if (list[0]=="A")
                    {
                        if (phoneNumbers.ContainsKey(list[1]))
                        {
                            phoneNumbers.Remove(list[1]);
                        }
                        phoneNumbers[list[1]] = list[2];
                    }

                   else if(list[0] == "S")
                    {
                        if (phoneNumbers.ContainsKey(list[1]))
                        {
                            Console.WriteLine($"{list[1]} -> {list[1]}");
                        }
                        else
                        {
                            Console.WriteLine($"{list[1]} does not exist");
                        }
                    }
                



            }
        }
    }
}
