using System;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Получить от пользователя вещественное значение - бюджет пользователя, и целое число - процент бюджета,
выделенный на компьютерные игры. Вычислить и вывести на экран сумму в рублях/евро/долларах, выделенную на 
компьютерные игры. Использовать спецификаторы формата для валют

*/

namespace s2t6
{
    class Program
    {
        public static double Percentage(double b, int p)
        {
            double s = b*p*0.01; 
            return (s);
        }
        public static void Main()
        {
            //the key pressed by the user
            ConsoleKeyInfo keytoexit;
            do
            {
                Console.Write("Input the budget: ");
                //the budget input by the user
                string inputb = Console.ReadLine();
                Console.WriteLine("Input the percent of money to buy video games ");
                string inputp = Console.ReadLine();
                //checking the input correctness
                if ((!double.TryParse(inputb, out double budget)) | (!int.TryParse(inputp, out int percent)) | (budget<=0) | (percent <= 0))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    //calculating the amount of money
                    double money_amount = Percentage(budget, percent);
                    //output
                    Console.WriteLine($"The amount of money up to be spent on computer games : {0:C}",money_amount);
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}
