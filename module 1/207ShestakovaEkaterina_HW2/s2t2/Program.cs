using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Ввести натуральное трёхначное число Р. 
Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.

*/

namespace s2t2
{
    class Program
    {
        public static int Pchanger(int x)
        {
            //splitting the number into digits
            int n3 = x % 10;
            int n2 = x / 10 % 10;
            int n1 = x / 100;
            //the digits of the final number
            int a1, a2, a3;
            //the smallest one
            a3 = n3 < n2 ? (n3 < n1 ? n3 : n1) : (n2 < n1 ? n2 : n1);
            //the biggest one
            a1 = n3 > n2 ? (n3 > n1 ? n3 : n1) : (n2 > n1 ? n2 : n1);
            //the medium one
            a2 = n3 < n2 ? (n1 < n3 ? n3 : (n1 < n2 ? n1 : n2)) : (n1 >= n3 ? n3 : (n1 <= n2 ? n2 : n1));
            return (a1 * 100 + a2 * 10 + a3);
        }
        public static void Main()
        {
            //the key pressed by the user
            ConsoleKeyInfo keytoexit;
            do
            {
                Console.Write("Input the number: ");
                //the number input by the user
                string input = Console.ReadLine();
                //checking the input correctness
                if ((!int.TryParse(input, out int p))|(input.Length!=3)|(p<0))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    //calculating the wanted number
                    int val = Pchanger(p);
                    //output
                    Console.WriteLine("The wanted number: " + val);
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}
