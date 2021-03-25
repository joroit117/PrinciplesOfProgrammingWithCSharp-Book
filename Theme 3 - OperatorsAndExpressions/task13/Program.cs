using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            int i = 1;
            int mask = i << p;
            bool check = (n & mask) != 0 ? true : false;
            if (check == true && v == 0)
            {
                n = n & (~(1 << p));
            }
            else
            {
                n = n | (1 << p);
            }
            Console.WriteLine(n);
        }
    }
}
