using System;

namespace Sum1000div5or3
{
    // Найти сумму всех положительных чисел меньше 1000 кратных 3 или 5.
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
