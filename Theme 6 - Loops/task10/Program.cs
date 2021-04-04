using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double S = 1;
            double iFak = 1;
            double Pow = 1;
            for (int i = 1; i <= n; i++)
            {
                iFak *= i;
                Console.WriteLine(iFak);
                Pow *= x;
                Console.WriteLine(Pow);
                S += (iFak / Pow); 
            }
            Console.WriteLine($"{S:f2}");
        }
    }
}
