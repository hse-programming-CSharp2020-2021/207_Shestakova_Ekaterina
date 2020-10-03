using System;
using System.Threading;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Написать программу с использованием двух методов.
Первый метод возвращает целую и дробную часть числа.
Второй метод возвращает квадрат и корень из числа.
В основной программе пользователь вводит дробное число.
Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную часть из числа.

*/

namespace s2t7
{
    class Program
    {
        public static (int, double) Method1(double a)
        {
            //the int-part of the number
            int z = (int)a;
            //the fractional partv of the number
            double rac = a - z;
            return (z, rac);
        }
        
        public static (string,double) Method2(double a)
        {
            //checking the possibility of calculating the square root
            string sqroot;
            if (a < 0)
            {
                sqroot = "the square root is impossible to be calculated";
            }
            else
            {
                sqroot = "the square root = " + Math.Sqrt(a).ToString();
            }
            double sq = a * a;
            return (sqroot, sq);

        }
        static void Main(string[] args)
        {
            //the key pressed by the user
            ConsoleKeyInfo keytoexit;
            do
            {
                Console.Write("Input the number: ");
                //the number input by the user
                string input = Console.ReadLine();
                //checking the input correctness
                if (!double.TryParse(input, out double number))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    //calculating the integer and the fractial part of the number
                    var parts = Method1(number);
                    //calculating the square root and the square of the number
                    var squarethings = Method2(number);
                    //output
                    Console.WriteLine($"The integer part is {parts.Item1}, the fractial part is {parts.Item2}, {squarethings.Item1}, the square of the number = {squarethings.Item2}");
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}
