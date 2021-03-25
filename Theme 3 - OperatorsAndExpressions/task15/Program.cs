using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bit3 = (number >> 3) & 1;
            int bit4 = (number >> 4) & 1;
            int bit5 = (number >> 5) & 1;
            int bit24 = (number >> 24) & 1;
            int bit25 = (number >> 25) & 1;
            int bit26 = (number >> 26) & 1;
            number = number & (~(1 << 24)) | (bit3 << 24);
            number = number & (~(1 << 3)) | (bit24 << 3);
            number = number & (~(1 << 25)) | (bit4 << 25);
            number = number & (~(1 << 4)) | (bit25 << 4);
            number = number & (~(1 << 26)) | (bit5 << 26);
            number = number & (~(1 << 5)) | (bit26 << 5);
            Console.WriteLine(number);
        }
    }
}
