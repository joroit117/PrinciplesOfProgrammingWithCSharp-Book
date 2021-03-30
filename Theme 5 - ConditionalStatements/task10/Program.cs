using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());
            if (points >= 1 && points <= 3)
            {
                points *= 10;
                Console.WriteLine(points);
            }
            else if (points >= 4 && points <= 6)
            {
                points *= 100;
                Console.WriteLine(points);
            }
            else if (points >= 7 && points <= 9)
            {
                points *= 1000;
                Console.WriteLine(points);
            }
            else if(points == 0 || points > 9)
            {
                Console.WriteLine("Mistake");
            }
        }
    }
}
