using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_IgraNaDumi
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0,maxS=0;
            string maxWord = " ";
            string word = Console.ReadLine();

            while (true)
            {
                if (word=="END OF GAME")
                {
                    break;
                }
                for (int i = 0; i < word.Length; i++)
                {
                    s += (int)(word[i]);

                }

                if (word[0] > 'A' && word[0] < 'Z')
                {
                    s += 15;
                }

                int last = word.Length - 1;
                if (word[word.Length - 1] == 't')
                {
                    s += 20;
                }
                if (word.Length >= 10)
                {
                    s += 30;
                }
                if (maxS<s)
                {
                    maxS = s;
                    maxWord = word;
                }
               // points.Add(s);
                s = 0;
                word = Console.ReadLine();
            }
            Console.WriteLine($"Winner is world: {maxWord}");
            Console.WriteLine($"Points: {maxS}");
            
        }
    }
}
