using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("S = " + Math.PI * Math.Pow(r,2));
            Console.WriteLine("P = " + 2 * Math.PI * r);
        }
    }
}
