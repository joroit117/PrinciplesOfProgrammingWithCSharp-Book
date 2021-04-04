using System;

namespace task10___Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int k = n;
            for(int i = 1; i <= n; i++)
            {
                for(int j = i; j <= k; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
                k++;
            }    

        }
    }
}
