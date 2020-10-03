using System;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Ввести значение х и вывести значение полинома F(x) = 12х^4 + 9x^3 - 3x^2 + 2x - 4. 
Не применять возведение в степень.
Использовать минимальное количество операций умножения.

*/

namespace HW2
{
    class Program
    {
        public static double F(double a)
        {
            return ((((12 * a + 9) * a - 3) * a + 2) * a - 4);
        }
        public static void Main()
        {
            //the key pressed by the user
            ConsoleKeyInfo keytoexit;
            do
            {
                Console.Write("Input x: ");
                //the value of x input by the user
                string input = Console.ReadLine();
                //checking the input correctness
                if (!double.TryParse(input, out double x))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    //calculating the value of the polynome
                    double val = F(x);
                    //output
                    Console.WriteLine("The value of the polynome: " + val);
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}
