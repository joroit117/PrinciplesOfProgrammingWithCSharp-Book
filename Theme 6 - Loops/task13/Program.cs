using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double n = 0;
            int e = s.Length-1;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int k = 0;
                if (c == 'A' || c == 'B' || c == 'C' || c == 'D' || c == 'E' || c == 'F')
                {
                    switch (c)
                    {
                        case 'A':
                            k = 10;
                            break;
                        case 'B':
                            k = 11;
                            break;
                        case 'C':
                            k = 12;
                            break;
                        case 'D':
                            k = 13;
                            break;
                        case 'E':
                            k = 14;
                            break;
                        case 'F':
                            k = 15;
                            break;
                    }
                }
                else
                {
                    k = int.Parse(c.ToString());
                }
                n += k * Math.Pow(16, e);
                e--;
            }
            Console.WriteLine(n);
        }
    }
}
