using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for (int i = 0; i < 20; i++)
            {
                array[i] = (i + 1) * 5;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
    }
}
