using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int greater = Math.Max(a, b);
            int smaller = Math.Min(a, b);

            Console.WriteLine(greater);
        }
    }
}
