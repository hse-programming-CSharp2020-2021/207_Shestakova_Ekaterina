using System;
using System.Numerics;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Введя значения коэффициентов A, B, C, вычислить корни квадратного уравнения.
Учесть (как хотите) возможность появления комплексных корней.
Оператор if не применять.

*/

namespace s2t3
{
    class Program
    {
        public static string Roots(double a, double b, double c)
        {
            //calculating the discriminant
            double d = b * b - 4 * a * c;
            //calculating if there are complex roots, 0 for no, 1 for yes
            int i = d >= 0 ? 0 : 1;
            d = Math.Abs(d);
            //calculating the roots as if they were not complex
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            //calculating the complex part of the complex roots
            string u = (Math.Sqrt(d) / (2 * a)) + "i";
            //calculating the roots taking the comlexity into account
            string xx1 = i == 0 ? x1.ToString() : (-b / (2 * a)).ToString() + "+" + u;
            string xx2 = i == 0 ? x2.ToString() : (-b / (2 * a)).ToString() + "-" + u;
            //calculating th roots taking into account the number of the roots
            string finalstr = xx1 == xx2 ? "The only root is: " + xx1 : "The first root is " + xx1 + ", and the second root is " + xx2;
            return finalstr;
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
                    //calculating the value(s) of the roots
                    string values = Roots(A, B, C);
                    //output
                    Console.WriteLine(values);
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}//в программе не учтен ввод а=0
