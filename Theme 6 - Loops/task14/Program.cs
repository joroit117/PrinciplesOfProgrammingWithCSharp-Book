using System;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = "";
            string h = "";
            while (n > 0)
            {
                    int k = n % 16;
                    if(k >= 10 && k <= 15)
                    {
                        switch(k)
                        {
                        case 10:
                            s += "A";
                            break;
                        case 11:
                            s += "B";
                            break;
                        case 12:
                            s += "C";
                            break;
                        case 13:
                            s += "D";
                            break;
                        case 14:
                            s += "E";
                            break;
                        case 15:
                            s += "F";
                            break;
                        }
                    }
                else
                {
                    s += (n % 16).ToString();
                }
                n /= 16;
            }

            for (int i = s.Length - 1; i >= 0; i--)
            {
                char c = s[i];
                h += c;
            }
            Console.WriteLine(h);
        }
    }
}
