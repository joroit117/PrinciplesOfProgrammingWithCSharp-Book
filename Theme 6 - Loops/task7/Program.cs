using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int a = n - k;
            int nFak = 1;
            int kFak = 1;
            int aFak = 1;

            for (int i = n; i > 0; i--)
            {
                nFak *= i;
            }
            for (int i = k; i > 0; i--)
            {
                kFak *= i;
            }
            for (int i = a; i > 0; i--)
            {
                aFak *= i;
            }

            Console.WriteLine(nFak * kFak / aFak);
        }
    }
}
