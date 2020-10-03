using System;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Написать метод, вычисляющий логическое значение функции G=F(x)
*/

namespace s3ts3
{
    class Program
    {
        public static double G(double xc)
        {
            double g;
            if (xc <= 0.5)
            {
                g = 1;
            }
            else
            {
                g = Math.Sin((Math.PI*(xc-1))/2);
            }
            return (g);
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
                //checking the input correctness
                if (!double.TryParse(X, out double x))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {  //output
                    Console.WriteLine("The value of the G function = " + G(x));
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}

