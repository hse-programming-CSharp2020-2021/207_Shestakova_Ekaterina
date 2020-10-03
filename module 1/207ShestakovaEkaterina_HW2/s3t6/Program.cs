using System;
using System.Xml.Schema;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Написать метод для рассчёта сложных процентов Вывести таблицу значений итоговых сумм в конце каждого года вплоть до заданного числа лет
*/

namespace s3t6
{
    class Program
    {
        public static void Main()
        {
            double k, r;
            uint n;
            do
            { //start capital
                Console.Write("Input the start capital = ");
            } while ((!double.TryParse(Console.ReadLine(), out k)) | (k <= 0));
            do
            { //the interest rate
                Console.Write("Input the interest rate = ");
            } while ((!double.TryParse(Console.ReadLine(), out r)) | (r <= 0));
            do
            { //the number of years
                Console.Write("Input the number of years = ");
            } while ((!uint.TryParse(Console.ReadLine(), out n)) | (n == 0));

            //the head of the table
            Console.WriteLine("Year             Final sum in the account");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("   "+i + "                   " + $"{ Total(k, r, i):f5}");
            } //the contents of the table
        }
        public static double Total(double cap, double rate, int years)
        {
            double summ = cap;
            // calculating the sum in the account in the exact year
            for (int j = 1; j <= years; j++)
            {
                summ *= 1 + rate / 100;
            }
            return (summ);
        }
    }
}
