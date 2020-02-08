using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Word_3_IndexBukva
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[30];
            int index = 1;
            for (char i = 'a'; i <= 'z'; i++)
            {

                alphabet[index] = i;
                index++;
            }

            Console.WriteLine(String.Join(" ",alphabet));

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i]==alphabet[j])
                    {
                        Console.WriteLine($"{word[i]}->{j}");
                    }
                }
            }
        }

       

       
    }
}
