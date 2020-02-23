using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VhodPechatMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Dictionary<string, int>();
            Console.Write("Broy elementi:");
            int brEl = int.Parse(Console.ReadLine());
            for (int i = 0; i < brEl; i++)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());
                person.Add(name,age);
            }


            foreach (var item in person)
            {
                Console.WriteLine($"Name: {item.Key} => {item.Value} years");
            }


            //Промяна на стойност по ключ
            person["a"] = 2;

            //Добавяне на нов елемент 
            person["Name"] = 10;
            person.Add("NAME_1", 100);

            Console.WriteLine();
            foreach (KeyValuePair<string,int> item in person)
            {
                Console.WriteLine($"Name: {item.Key} => {item.Value} years");
            }


            //Проверка дали даден ключ се съдържа в речника
            Console.WriteLine();
            foreach (var item in person)
            {
                if (person.ContainsKey("Name"))
                {
                    Console.WriteLine("Yes,ima element sas КЛЮЧ Name");
                    break;
                }
            }

            //Проверка дали даденa стойност се съдържа в речника
            Console.WriteLine();
            foreach (var item in person)
            {
                if (person.ContainsValue(100))
                {
                    Console.WriteLine($"{item.Key} ====> {item.Value}");
                }
            }

            //Сортиране по ключ
            Console.WriteLine();
            Console.WriteLine("Сортиране по ключ");
            foreach (var item in person.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} ====> {item.Value}");
            }

            //Сортиране по стойност
            Console.WriteLine();
            Console.WriteLine("//Сортиране по стойност");
            foreach (var item in person.OrderBy(x => x.Value))
            {
                Console.WriteLine($"{item.Key} ====> {item.Value}");
            }

            //Изтриване на елемент от речник по ключ
            Console.WriteLine();
            Console.WriteLine("Изтриване на елемент от речник по ключ");
            person.Remove("Name");
            foreach (KeyValuePair<string, int> item in person)
            {
                Console.WriteLine($"Name: {item.Key} => {item.Value} years");
            }

            //Брой на елементите на речник
            Console.WriteLine();
            Console.WriteLine("Брой на елементите на речник");
            int brEl_Rechnik = person.Count;
            Console.WriteLine($"Брой:[{brEl_Rechnik}]");


        }
    }
}
