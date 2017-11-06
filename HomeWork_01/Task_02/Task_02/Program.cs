using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int summ = 0, digit;
                int i = 1;
                string input;
                bool success;

                //можно легко изменить количество цифр для ввода
                int maxInput = 3;

                Console.Clear();
                Console.WriteLine("Программа запросит у вас ввести " + maxInput + " числа(-ел) и выведет их сумму!");
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();

                while (i <= maxInput)
                {
                    Console.Clear();
                    Console.WriteLine("Введите число " + i + ":");
                    input = Console.ReadLine();
                    success = Int32.TryParse(input, out digit);

                    if (success)
                    {
                        summ += digit;
                        i++;
                    }
                }

                Console.Clear();
                Console.WriteLine("Сумма введенных вами чисел равна: " + summ);
                Console.ReadKey();
            }




        }
    }
}
