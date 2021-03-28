using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 0; i < 5; i++)
            {
                int j = 0;
                string s = Console.ReadLine();
                bool result = int.TryParse(s, out j);
                if(j == 0)
                {
                    Console.WriteLine("Invalid number! Please try again!");
                    i--;
                }
                else
                {
                    sum += j;
                    j = 0;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
