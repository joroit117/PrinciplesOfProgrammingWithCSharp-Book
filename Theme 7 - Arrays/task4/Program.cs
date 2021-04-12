using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int[] midarr = new int[n];
            int[] maxarr = new int[n];
            int br = 1;
            int maxbr = Int32.MinValue;
            for(int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < n-1; i++)
            {
                if(array[i] == array[i+1])
                {
                    midarr[br - 1] = array[i];
                    midarr[br] = array[i + 1];
                    br++;
                }
                else
                {
                    if(br > maxbr)
                    {
                        maxbr = br;
                        for(int j = 0; j < midarr.Length; j++)
                        {
                            maxarr[j] = midarr[j];
                            midarr[j] = 0;
                        }
                        br = 1;
                    }
                    else
                    {
                        br = 1;
                        for (int j = 0; j < midarr.Length; j++)
                        {
                            midarr[j] = 0;
                        }
                    }

                }
                
            }
            for(int i = 0; i < maxbr; i++)
            {
                Console.Write(maxarr[i] + " ");
            }
        }
    }
}
