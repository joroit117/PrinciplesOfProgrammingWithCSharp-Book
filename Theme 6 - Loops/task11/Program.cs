using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long nFak = 1;

            for (int i = n; i > 0; i--)
            {
                nFak *= i;
            }
            int br = 0;
            string s = nFak.ToString();
            int length = s.Length;
            while(true)
            {
                char c = s[length-1];
                if(c == '0')
                {
                    br++;
                }
                else
                {
                    break;
                }
                length--;
            }
            Console.WriteLine(br);
        }
    }
}
