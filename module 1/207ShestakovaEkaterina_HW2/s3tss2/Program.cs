﻿using System;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Написать метод, вычисляющий логическое значение функции G=F(x,y)
*/

namespace s3ts3
{
    class Program
    {
        public static double G(double xc, double yc)
        {
            double g;
            if ((xc < yc) & (xc > 0))
            {
                g = xc + Math.Sin(yc);
            }
            else if ((xc > yc) & (xc < 0))
            {
                g = yc - Math.Cos(xc);
            }
            else
            {
                g = 0.5 * xc * yc;
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
                Console.Write("Input the y coordinate: ");
                string Y = Console.ReadLine();
                //checking the input correctness
                if ((!double.TryParse(X, out double x)) | (!double.TryParse(Y, out double y)))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {  //output
                    Console.WriteLine("The value of the G function = " + G(x, y));
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}

