using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Word_3_BulPr
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            Convert.ToBoolean(n);
            if (n=="true")
            {
                Console.WriteLine("Yes");
            }
            else if(n=="false")
            {
                Console.WriteLine("No");
            }
        }
    }
}
