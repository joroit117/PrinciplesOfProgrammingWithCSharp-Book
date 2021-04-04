using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a > max) max = a;
                if (a < min) min = a;
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
