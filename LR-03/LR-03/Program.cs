using System;

namespace LR_03
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Лабораторная работа 3.");
            Console.WriteLine("Разрешается вводить только числа!");
            Console.WriteLine("Введите число x:");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильный формат числа. Попробуйте еще раз.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите число x:");
            }

            Console.WriteLine("Введите степень n:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неправильный формат числа. Попробуйте еще раз.");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите степень n:");
            }

            double result = Power(x, n);
            Console.WriteLine($"Результат: {result}");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Спасибо за использование моей программы!");
            Console.ReadLine();
        }
            
        static public double Power(double x, int n)
        {
            if (n < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Недопустимое значение параметра n");
                return 1;
            }
            double z = 1;
            for (int i = 1; i <= n; i++)
            {
                z = z * x;
            }
            return z;
        }
    }
}