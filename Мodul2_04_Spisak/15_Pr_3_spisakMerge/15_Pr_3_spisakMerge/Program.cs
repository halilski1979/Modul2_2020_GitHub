using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Pr_3_spisakMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            //UNDER CONSTRUCTION

            List<string> spisakMerge = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();
            for (int i = 0; i < spisakMerge.Count; i++)
            {
                result[i] = spisakMerge[i];
            }
            
            spisakMerge.Reverse();
            Console.WriteLine(string.Join(" ",spisakMerge));
            
        }
    }
}
