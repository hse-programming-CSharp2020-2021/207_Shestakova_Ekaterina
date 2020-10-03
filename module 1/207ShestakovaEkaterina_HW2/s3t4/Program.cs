using System;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Написать метод для вычисления по формуле Ньютона с точностью до машинного нуля приближенного значения арифметического квадратного корня
*/

namespace s3t4
{
    class Program
    {
        static void Main()
        {
            double x, result;
            Console.Title = "Newton's formula";
            //the key pressed by the user
            ConsoleKeyInfo keytoexit;
            do
            {
                do
                {
                    Console.Clear();
                    //the number input by the user
                    Console.Write("Input the number: ");
                } while (!double.TryParse(Console.ReadLine(), out x));
                
                if (!Newton(x, out result))
                {
                    Console.WriteLine("The x number is negative, try another");
                }
                else
                {
                    Console.WriteLine($"The square root of {x:f5} = {result:f5}");
                }
                
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }

        public static bool Newton(double x, out double result)
        {
            double oldsqrt, newsqrt;
            if (x <= 0.0)
            {
                result = 0.0;
                return false;
            }
            else
            {
                newsqrt = x;
                do
                {
                    oldsqrt = newsqrt;
                    newsqrt = 0.5 * (oldsqrt + x / (oldsqrt));

                } while (oldsqrt != newsqrt);
                result = newsqrt;
                return true;
            }
        }
    }
}
