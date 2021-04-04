using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            Console.Write(a + " ");
            Console.Write(b + " ");
            for(int i = 1; i < n; i++)
            {
                Console.Write(a + b + " ");
                int c = a;
                a = b;
                b = c + b;
            }
        }
    }
}
