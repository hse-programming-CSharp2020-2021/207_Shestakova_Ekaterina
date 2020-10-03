using System;

namespace s3ts1
{
    class Program
    {
        public static (int,int,int,int) Number()
        {
            int s, i = 1;
            s = i;
            int lasti1 = 0, lasti2 = 0, lasti3 = 0;
            while ((s.ToString().Length != 3) | (s % 10 != s / 100) | (s % 10 != s / 10 % 10))
            {
                s += i + 1;
                lasti3 = i + 1;
                lasti2 = i;
                lasti1 = i - 1;
                i++;

            }
            return (s,lasti1,lasti2,lasti3);
        }
        static void Main(string[] args)
        {
            var results = Number();
            Console.WriteLine($"The number is {results.Item1}, its sum is 1 + 2 + 3 + ... + {results.Item2} + {results.Item3} + {results.Item4}");
        }
    }
}
