using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double D = b * b - 4 * a * c;
            double x1 = 0;
            double x2 = 0;
            if(D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2;
                x2 = (-b - Math.Sqrt(D)) / 2;
                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
            else if(D == 0)
            {
                x1 = x2 = -b / 2;
                Console.WriteLine(x1);
            }
            else if(D < 0)
            {
                Console.WriteLine("Nqma koreni");
            }
        }
    }
}
