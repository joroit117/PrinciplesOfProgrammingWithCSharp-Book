using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int biggestSum = 0;
            int sum = 0;
            int start = 0;

            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n - k; i++)
            {
                for(int j = i; j < k + i; j++)
                {
                    sum += array[j];
                }
                if(sum > biggestSum)
                {
                    biggestSum = sum;
                    start = i;
                }
                sum = 0;
            }
            for(int i = start; i < k + start; i++)
            {
                Console.Write(array[i] + " ");
            }


        }
    }
}
