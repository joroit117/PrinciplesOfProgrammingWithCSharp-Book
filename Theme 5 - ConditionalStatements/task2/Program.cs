using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int negative = 0;
            for(int i = 0; i < 3; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if(n < 0)
                {
                    negative++;
                }
            }
            if(negative % 2 == 0)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}
