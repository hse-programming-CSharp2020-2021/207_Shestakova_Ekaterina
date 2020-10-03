using System;
using System.Reflection.Metadata.Ecma335;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Получить от пользователя четырёхзначное натуральное число и вывести его цифры в обратном порядке

*/

namespace s2t4
{
    class Program
    {
        public static string Reverse(int n)
        {
            return ((n % 10 * 1000 + n % 100 / 10 * 100 + n / 100 % 10 * 10 + n / 1000).ToString());
        }
        public static void Main(string[] args)
        {
            //the key pressed by the user
            ConsoleKeyInfo keytoexit;
            do
            {
                Console.Write("Input the number: ");
                //the number input by the user
                string input = Console.ReadLine();
                //checking the input correctness
                if ((!int.TryParse(input, out int number)) | (input.Length != 4) | (number <= 0))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    //calculating the new number
                    string newnumber = Reverse(number);
                    //output
                    while (newnumber.Length != 4)
                    {
                        newnumber = "0" + newnumber;
                    }
                    Console.WriteLine("The new number is: " + newnumber);
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}
