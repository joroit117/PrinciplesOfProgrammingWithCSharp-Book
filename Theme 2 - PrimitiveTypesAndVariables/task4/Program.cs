using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool bit3 = (num & 8) != 0;
            Console.WriteLine(bit3);
        }
    }
}
