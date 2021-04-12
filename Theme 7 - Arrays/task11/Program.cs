using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter s: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter arr: ");
            int[] array = new int[n];
            int sum = 0;
            int begin = 0;
            int end = 0;
            bool exist = false;

            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if(sum == s)
                    {
                        begin = i;
                        end = j;
                        sum = 0;
                        exist = true;
                        break;
                    }
                    else if(sum > s)
                    {
                        sum = 0;
                        break;
                    }
                    sum += array[j];
                }
                sum = 0;
            }
            if (exist == false)
            {
                Console.WriteLine("No sum like that!");
            }
            else
            {
                for(int i = begin; i < end; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}
