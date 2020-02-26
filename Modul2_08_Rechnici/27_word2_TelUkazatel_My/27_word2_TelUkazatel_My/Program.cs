using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_word2_TelUkazatel_My
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ukazatel = new Dictionary<string, string>();
            List<string> linia = Console.ReadLine().Split(' ').ToList();
            while (true)
            {
                
                var command = linia[0];
                if (command=="end")
                {
                    break;
                }

                

                //Add and update - OK
                if (command=="A")
                {
                    var name = linia[1];
                    var nomer = linia[2];
                    if (ukazatel.ContainsKey(name))
                    {
                        ukazatel.Remove(name);
                        name = linia[1];
                        nomer = linia[2];
                    }
                    ukazatel.Add(name,nomer);
                    Console.WriteLine(string.Join(" ", ukazatel));
                }

                //Print 
                if (command == "S")
                {
                    string name = linia[1];
                   
                        if (ukazatel.ContainsKey(name))
                        {

                            Console.WriteLine($"Ime:{name}=>Nomer: {ukazatel[name]}");
                        }
                        else
                        {
                            Console.WriteLine($" {name} does not exist");
                        }
                    
                }
                linia = Console.ReadLine().Split(' ').ToList();
            }
            
        }
    }
}
