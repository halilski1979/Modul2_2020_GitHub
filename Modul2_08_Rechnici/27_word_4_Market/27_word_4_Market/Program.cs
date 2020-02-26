using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_word_4_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> market = new Dictionary<string, List<double>>();

            
            double s = 0;
            while (true)
            {
                List<string> linia = Console.ReadLine().Split(' ').ToList();
                string stoka = linia[0];
                if (stoka=="stocked")
                {
                    break;
                }

                double price = double.Parse(linia[1]);
                double quantity = double.Parse(linia[2]);

                if (market.ContainsKey(stoka))
                {
                    //обхождаме речника 
                    for (int i = 0; i < market[stoka].Count; i++)

                    {

                        if (market[stoka][0] != price)

                        {

                            market[stoka][0] = price;

                        }

                        market[stoka][1] += quantity;

                    }
                }
                else
                {
                    var list = new List<double>();
                    list.Add(price);
                    list.Add(quantity);
                    market.Add(stoka, list);
                }
                

            }

            foreach (var item in market)
            {
                Console.WriteLine($"{item.Key}: ${item.Value[0]:f2}*{item.Value[1]} = ${item.Value[0]*item.Value[1]:f2}");
                s += item.Value[0] * item.Value[1];
            }
            Console.WriteLine("----------------------");
            Console.WriteLine($"Grand total: ${s:f2}");
        }
    }
}
