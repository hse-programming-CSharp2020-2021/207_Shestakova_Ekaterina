using System;

/*

Шапка

Дисциплина: "Программирование"

Группа: БПИ207

Студент: Шестакова Екатерина

Дата: 23.09.2020

Задача: Трёхзначным целым числом кодируется номер аудитории в учебном корпусе.
Старшая цифра обозначает номер этажа, а две младшие - номер аудитории на этаже.
Из трёх аудиторий определить и вывести на экран ту аудиторию, 
которая имеет минимальный номер внутри этажа.
Если таких аудиторий несколько - вывести любую из них.

*/

namespace s2tss4
{
    class Program
    {
        public static int Auditory(int x, int y, int z)
        {
            int a1 = x - x / 100 * 100;
            int a2 = y - y / 100 * 100;
            int a3 = z - z / 100 * 100;
            int final = a1 < a2 ? (a1 < a3 ? x : z) : (a2 < a3 ? y : z);
            return (final);
        }
        public static void Main()
        {
            //the key pressed by the user
            ConsoleKeyInfo keytoexit;
            do
            {
                Console.Write("Input the first auditory number: ");
                //the numbers of the auditories input by the user
                string inputa = Console.ReadLine();
                Console.Write("Input the second auditory number: ");
                string inputb = Console.ReadLine();
                Console.Write("Input the third auditory number: ");
                string inputc = Console.ReadLine();
                //checking the input correctness
                if ((!int.TryParse(inputa, out int A)) | (!int.TryParse(inputb, out int B)) | (!int.TryParse(inputc, out int C))
                        | (A <= 0) | (B <= 0) | (C <= 0)
                        | (inputa.Length!=3) | (inputb.Length != 3) | (inputc.Length != 3))
                {
                    Console.WriteLine("Incorrect input");
                }
                else
                {
                    //calculating the wanted number
                    int aud = Auditory(A, B, C);
                    //output
                    Console.WriteLine("The wanted auditory's number: " + aud);
                }
                //epilogue
                Console.WriteLine("Press 'esc' to exit, press any key otherwise");
                keytoexit = Console.ReadKey();
                Console.WriteLine("");
            } while (keytoexit.Key != ConsoleKey.Escape);
        }
    }
}

