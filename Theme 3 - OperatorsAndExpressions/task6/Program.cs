using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double p = (a + b) * 2;
            double s = a * b;

            Console.WriteLine("Perimeter: " + p);
            Console.WriteLine("Area: " + s);
        }
    }
}
