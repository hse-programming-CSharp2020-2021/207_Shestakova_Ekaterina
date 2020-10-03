using System;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Написать метод для решения квадратного уравнения.
Параметры - коэффициенты уравнения A,B,C, и два параметра для получения значений вещественных корней


*/

namespace s2t3
{
    class Program
    {
        public static bool Roots(double a, double b, double c, out double x1, out double x2)
        {
            //calculating the discriminant
            double d = b * b - 4 * a * c;
            if (((a == b) & (b == c) & (c == 0)) | ((a == b) & (b == 0) & (c != 0))|(d<0))
            {
                x1 = 0;
                x2 = 0;
                return false;
            }
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                return true;
            }
        }
        public static void Main()
        {
            //the key pressed by the user
            ConsoleKeyInfo keytoexit;
            do
            {
                Console.Write("Input a: ");
                //the value of a, b and c input by the user
                string inputa = Console.ReadLine();
                Console.Write("Input b: ");
                string inputb = Console.ReadLine();
                Console.Write("Input c: ");
                string inputc = Console.ReadLine();
                //checking the input correctness
                if ((!double.TryParse(inputa, out double A)) | (!double.TryParse(inputb, out double B)) | (!double.TryParse(inputc, out double C)))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    if (!Roots(A, B, C, out double x1, out double x2 ))
                    {
                        Console.WriteLine("There are no real roots");
                    }
                    else
                    {
                        if (x1 == x2)
                        {
                            Console.WriteLine($"The only root of the equality = {x1:f5}");
                        }
                        else
                        {
                            Console.WriteLine($"The first root is {x1:f5}, and the second root is {x2:f5}");
                        }
                    }
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}
