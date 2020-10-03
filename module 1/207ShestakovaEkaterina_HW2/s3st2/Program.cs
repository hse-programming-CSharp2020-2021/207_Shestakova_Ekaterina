using System;
using System.Security.Cryptography.X509Certificates;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Написать метод, преобразующий число, переданное в качестве параметра в число,
записанное теми же цифрами, но идущими в обратном порядке
*/

namespace s2t4
{
    class Program
    {
        public static int Reverse(int n)
        {
            int newnumber = 0;
            while (n > 0)
            {
                newnumber = newnumber * 10 + n % 10;
                n = n / 10;
            }
            return (newnumber);
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
                if ((!int.TryParse(input, out int number)) | (number <= 0))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    //calculating the new number
                    int nwnumber = Reverse(number);
                    //output
                    Console.WriteLine("The new number is: " + nwnumber);
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}
