using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] sorted = new int[n];
            int min = Int32.MaxValue;

            int[] array = new int[n];
            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int index = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = i; j < n; j++)
                {
                    if(array[j] < min)
                    {
                        min = array[j];
                        index = j;
                    }
                }
                swap(ref array[i], ref array[index]);
                min = Int32.MaxValue;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i]);
            }
        }
        static void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
