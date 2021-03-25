using System;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    isPrime = false;
            }
            if(isPrime == true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Non-prime");
            }
        }
    }
}
