using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_word_3_MinyoskaZadacha_MY
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> polIzk = new Dictionary<string, int>();

            while (true)
            {
                Console.Write("Resource OR stop:");
                string resource = Console.ReadLine();
                if (resource=="stop")
                {
                    break;
                }

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                if (polIzk.ContainsKey(resource))
                {
                    polIzk[resource] += quantity;
                    
                }
                else
                {
                    polIzk.Add(resource, quantity);
                }
               
                    
                
                
            }
            Console.WriteLine(string.Join(" ",polIzk ));
        }
    }
}
