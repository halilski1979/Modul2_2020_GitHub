using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4_FutbolenOtbor
{
    class Program
    {
        static void Main(string[] args)
        {

            var linia = Console.ReadLine().Split('-').ToList();
            Dictionary<string, int> otbor = new Dictionary<string, int>();
                  
            while (linia[0]!="end")
            {

                    var name = linia[0];        
                    var goals = int.Parse(linia[1]);

                  
                        if (otbor.ContainsKey(name))
                        {
                            otbor[name] += goals;
                        }
                        else
                        {
                            otbor.Add(name, goals);
                        }
                   
                

                linia = Console.ReadLine().Split('-').ToList();
            }
            
            foreach (var item in otbor.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} => {item.Value} ");
            }
            Console.WriteLine();
            foreach (var item in otbor.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} => {item.Value} ");
            }
        }
    }
}
