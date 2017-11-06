using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string name;
                Console.Clear();
                Console.WriteLine("Пожалуйста введи свое имя!");
                name = Console.ReadLine();

                name = name.Trim();

                if (!String.IsNullOrWhiteSpace(name))
                    Console.WriteLine("\nПриветствую тебя - " + name);
                else
                    Console.WriteLine("\nПопробуй еще раз. Ты ведь ничего не ввел!");

                Console.ReadKey();
            }

        }
    }
}
