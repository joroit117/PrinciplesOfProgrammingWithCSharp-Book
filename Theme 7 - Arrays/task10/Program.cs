using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxCount = 0;
            int counter = 0;
            int common = 0;
            int mostCommon = 0;
            int min = Int32.MaxValue;

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        index = j;
                    }
                }
                swap(ref array[i], ref array[index]);
                min = Int32.MaxValue;
            }
            for (int i = 0; i < n - 1; i++)
            {
                if(array[i] == array[i + 1])
                {
                    counter++;
                    common = array[i];
                }
                else
                {
                    if(counter > maxCount)
                    {
                        maxCount = counter;
                        mostCommon = common;
                    }
                    counter = 0;
                    common = 0;
                }
            }
            Console.WriteLine("The most common is: " + mostCommon);
        }
        static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}