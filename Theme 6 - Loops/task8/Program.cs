using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long nMult2Fak = 1;
            long nPlus1Fak = 1;
            long nFak = 1;

            for (int i = n; i > 0; i--)
            {
                nFak *= i;
            }
            for (int i = n + 1; i > 0; i--)
            {
                nPlus1Fak *= i;
            }
            for (int i = n * 2; i > 0; i--)
            {
                nMult2Fak *= i;
            }

            Console.WriteLine(nMult2Fak / (nPlus1Fak * nFak));
        }
    }
}
