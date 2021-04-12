using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Height = 11;

            long[][] triangle = new long[Height + 1][];

            for(int row = 0; row < Height; row++)
            {
                triangle[row] = new long[row + 1];
            }

            triangle[0][0] = 1;

            for(int row = 0; row < Height - 1; row++)
            {
                for(int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            for(int row = 0; row < Height; row++)
            {
                Console.Write("".PadLeft((Height - row) * 2));
                for(int col = 0; col <= row; col++)
                {
                    Console.Write("{0, 3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
