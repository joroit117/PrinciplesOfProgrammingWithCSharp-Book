using System;

namespace task12b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int k = 1;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                counter++;
                if (counter % 2 == 0)
                {
                    k += n;
                }
                for (int j = 0; j < n; j++)
                {
                    a[j, i] = k;
                    if (counter % 2 == 0)
                    {
                        k--;
                    }
                    else
                    {
                        k++;
                    }
                }
                if (counter % 2 == 0)
                {
                    k += n+2;
                }
                k--;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" " + a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
