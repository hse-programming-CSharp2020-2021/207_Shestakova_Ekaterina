using System;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Получить от пользователя три вещественных числа и проверить для них неравенство треугольника.
Оператор if не применять.
Точность вывода три знака после запятой.

*/

namespace s2t5
{
    class Program
    {
        public static bool Triangle(double a, double b, double c)
        {
            return (((a+b)>c)&((a+c)>b)&((b+c)>a));
        }
        public static void Main(string[] args)
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
                if ((!double.TryParse(inputa, out double A)) | (!double.TryParse(inputb, out double B)) | (!double.TryParse(inputc, out double C))|(A<=0)|(B<=0)|(C<=0))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    //checking if the numbers are right for the triangle inequality
                    bool check = Triangle(A, B, C);
                    //output
                    Console.WriteLine("The fact that these numbers satisfy the triangle condition is "+check);
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}
