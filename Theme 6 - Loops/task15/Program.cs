using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double n = 0;
            int e = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                int k = int.Parse(c.ToString());
                n += k * Math.Pow(16, e);
                e--;
            }
            Console.WriteLine(n);
        }
    }
}
