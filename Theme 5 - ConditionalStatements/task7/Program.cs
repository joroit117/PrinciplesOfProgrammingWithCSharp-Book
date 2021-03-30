using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = Int32.MinValue;
            for(int i = 0; i < 5; i++)
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
