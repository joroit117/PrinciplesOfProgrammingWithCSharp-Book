using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int br = 0;

            if (a % 5 == 0)
            {
                while(a <= b)
                {
                    a += 5;
                    br++;
                }
            }
            else if (b % 5 == 0)
            {
                while (a <= b)
                {
                    b -= 5;
                    br++;
                }
            }
            else
            {
                while(a % 5 != 0)
                {
                    a++;
                }
                while(a <= b)
                {
                    a += 5;
                    br++;
                }
            }
            Console.WriteLine(br);
        }
    }
}
