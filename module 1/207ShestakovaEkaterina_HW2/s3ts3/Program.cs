using System;
using System.Security.Cryptography.X509Certificates;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Написать метод, вычисляющий логическое значение функции G=F(x,y)
Фигура G - сектор круга радиусом 2 в диапазоне углов от -90 до 45
*/

namespace s3ts3
{
    class Program
    {
        public static bool G(double xc, double yc)
        {
            return ((xc*xc+yc*yc<=4)&(xc>=0)&(yc<=xc));
        }
        static void Main()
        {
            //the key pressed by the user
            ConsoleKeyInfo keytoexit;
            do
            {
                Console.Write("Input the x coordinate: ");
                //the coordinates input by the user
                string X = Console.ReadLine();
                Console.Write("Input the y coordinate: ");
                string Y = Console.ReadLine();
                //checking the input correctness
                if ((!double.TryParse(X, out double x)) | (!double.TryParse(Y, out double y)))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    Console.WriteLine("The fact that the point belongs to the G area is "+G(x,y));
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}
