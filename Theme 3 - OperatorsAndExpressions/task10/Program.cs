using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int d = number % 10;
            int c = (number / 10) % 10;
            int b = (number / 100) % 10;
            int a = (number/ 1000) % 10;

            int sum = a + b + c + d;
            Console.WriteLine(sum);
            Console.WriteLine($"{d}{c}{b}{a}");
            Console.WriteLine($"{d}{a}{b}{c}");
            Console.WriteLine($"{a}{c}{b}{d}");
        }
    }
}
