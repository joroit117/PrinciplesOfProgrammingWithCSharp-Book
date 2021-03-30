using System;

namespace task4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b) swap(ref a, ref b);
            if (a > c) swap(ref a, ref c);
            if (b > c) swap(ref b, ref c);
            

            Console.WriteLine(a + " - " + b + " - " + c);
        }
        static void swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }
    }
}
