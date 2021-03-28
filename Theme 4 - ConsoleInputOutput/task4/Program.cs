using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"{a}         {b:f2}      {c:f2}      ");
        }
    }
}
