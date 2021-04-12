using System;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[n, n];
            int[][] b = new int[n][];
            int[][] c = new int[n][];
            int[][] d = new int[n][];

            
            for(int i = 0; i < n; i++)
            {
                int k = i + 1;
                for (int j = 0; j < n; i++)
                {
                    a[i, j] += k;
                    k += 4;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; i++)
                {
                    Console.Write(" " + a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
