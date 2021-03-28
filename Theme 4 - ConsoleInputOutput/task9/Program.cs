using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(Console.ReadLine());
                sum += k;
            }
            Console.WriteLine(sum);
        }
    }
}
