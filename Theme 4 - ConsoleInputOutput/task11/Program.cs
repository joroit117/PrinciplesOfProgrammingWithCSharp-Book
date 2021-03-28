using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonachi

            long a = 0;
            long b = 1;
            Console.WriteLine(a);
            Console.WriteLine(b);
            for(int i = 2; i <= 100; i++)
            {
                long c = a;
                a = b;
                b = b + c;
                Console.WriteLine(b);
            }
        }
    }
}
