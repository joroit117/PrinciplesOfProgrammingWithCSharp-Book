using System;

namespace task12a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                int k = i + 1;
                for(int j = 0; j < n; j++)
                {
                    a[i, j] = k;
                    k += n;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
