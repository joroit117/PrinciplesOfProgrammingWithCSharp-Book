using System;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    NOD(a, b);
                }
            }
            else
            {
                if (a % b == 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    NOD(b, a);
                }
            }
        }
        static void NOD(int a, int b)
        {
            int r = 1;
            int[] arr = new int[100];
            int i = 0;
            while (true)
            {
                if (r == 0)
                {
                    Console.WriteLine(arr[i - 2]);
                    break;
                }
                r = a % b;
                arr[i] = r;
                a /= b;
                int z = b;
                b = r;
                a = z;
                i++;
            }
        }
    }
}
