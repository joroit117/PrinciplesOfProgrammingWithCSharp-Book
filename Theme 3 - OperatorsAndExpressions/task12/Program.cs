using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int i = 1;
            int mask = i << p;

            Console.WriteLine((v & mask) != 0 ? true : false);

        }
    }
}
