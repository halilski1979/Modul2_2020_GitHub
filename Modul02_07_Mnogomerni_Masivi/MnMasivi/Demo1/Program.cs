using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intMatrix = { { 1, 2, 3 }, { 11, 12, 13 } };
            int brRedove = intMatrix.GetLength(0);
            int brKoloni = intMatrix.GetLength(1);

            Console.Write("brRed= ");
            int brRed = int.Parse(Console.ReadLine());
            Console.Write("brCol= ");
            int brCol = int.Parse(Console.ReadLine());

            int[,] mnMasiv = new int[brRed,brCol];
            for (int i = 0; i < brRed; i++)
            {
                for (int j = 0; j < brCol; j++)
                {
                    Console.Write($"A[{i},{j}]=");
                    mnMasiv[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("=====================");
            for (int i = 0; i < brRed; i++)
            {
                for (int j = 0; j < brCol; j++)
                {
                    Console.WriteLine($"A[{i},{j}]={mnMasiv[i,j]}");
                  
                }
            }

            Console.WriteLine("=====================");
            for (int i = 0; i < brRed; i++)
            {
                double sumRed = 0;
                for (int j = 0; j < brCol; j++)
                {
                    sumRed += mnMasiv[i, j];
                    Console.Write ($"{mnMasiv[i, j]} ");

                }
                double avgRed = sumRed / brCol;
                Console.WriteLine($"avg={avgRed}");
            }

            Console.WriteLine("*******Pechat intMatrix*********");
            for (int i = 0; i < brRedove; i++)
            {
                for (int j = 0; j < brKoloni; j++)
                {
                    Console.Write(intMatrix[i,j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
