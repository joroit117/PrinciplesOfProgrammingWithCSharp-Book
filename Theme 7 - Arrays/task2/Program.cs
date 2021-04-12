using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool areEqual = true;
            int[] array1 = { 10, 20, 30 };
            int[] array2 = { 10, 20, 30 };

            int length1 = array1.Length;
            int length2 = array2.Length;

            if(length1 == length2)
            {
                for(int i = 0; i < length1; i++)
                {
                    if(array1[i] != array2[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Not equal!");
            }
            if(areEqual == true)
            {
                Console.WriteLine("Are equal!");
            }
            else
            {
                Console.WriteLine("Not equal!");
            }
        }
    }
}
