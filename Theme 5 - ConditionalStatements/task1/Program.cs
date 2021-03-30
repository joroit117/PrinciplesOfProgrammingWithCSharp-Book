using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(a > b)
            {
                int c = a;
                a = b;
                b = c;
            }
            Console.WriteLine(a + " - " + b);
        }
    }
}
