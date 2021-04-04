using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int nFak = 1;
            int kFak = 1;

            for(int i = n; i > 0; i--)
            {
                nFak *= i;
            }
            for (int i = k; i > 0; i--)
            {
                kFak *= i;
            }

            Console.WriteLine(nFak / kFak);
        }
    }
}
