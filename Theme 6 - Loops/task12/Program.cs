using System;

namespace task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = "";
            string h = "";
            if (n == 0)
            {
                s = "0000";
            }
            else if(n == 1)
            {
                h = "0001";
            }
            else if(n == 2)
            {
                h = "0010";
            }
            else if(n == 3)
            {
                h = "0011";
            }
            else if(n == 4)
            {
                h = "0100";
            }
            else if(n == 5)
            {
                h = "0101";
            }
            else if (n == 6)
            {
                h = "0110";
            }
            else if (n == 7)
            {
                h = "0111";
            }
            else
            {
                while (n > 0)
                {
                    s += (n % 2).ToString();
                    n /= 2;
                }
                
                for(int i = s.Length - 1; i >= 0; i--)
                {
                    char c = s[i];
                    h += c;
                }
            }
            Console.WriteLine(h);
        }
    }
}
