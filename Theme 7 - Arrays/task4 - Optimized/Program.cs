using System;

namespace task4___Optimized
{
     class Program
        {
           static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int[] array = new int[n];

                int start = 0;
                int bestStart = 0;
                int counter = 1;
                int maxCounter = Int32.MinValue;
                bool nonStop = true;

                for (int i = 0; i < n; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] != array[i + 1])
                    {
                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            bestStart = start;
                            nonStop = false;
                        }
                        start = i + 1;
                        counter = 0;
                    }
                    counter++;
                }
                if (nonStop == true)
                {
                    maxCounter = n;
                    bestStart = 0;
                }
                for (int i = bestStart; i < bestStart + maxCounter; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
