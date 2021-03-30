using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = Int32.MinValue;
            for(int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if(n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine(max);
        }
    }
}
