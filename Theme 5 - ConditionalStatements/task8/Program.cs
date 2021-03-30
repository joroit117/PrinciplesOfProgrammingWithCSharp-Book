using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int type = int.Parse(Console.ReadLine());
            string n = Console.ReadLine();
            if(type == 0 || type == 1)
            {
                double num = double.Parse(n);
                num++;
                Console.WriteLine(num);
            }
            else if(type == 2)
            {
                n += "*";
                Console.WriteLine(n);
            }
        }
    }
}
