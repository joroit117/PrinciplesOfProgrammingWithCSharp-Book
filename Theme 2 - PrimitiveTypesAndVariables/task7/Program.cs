using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightOnEarth = double.Parse(Console.ReadLine());
            double weightOnMoon = 0.17 * weightOnEarth;

            Console.WriteLine("Weight on moon: " + weightOnMoon + "kg");
        }
    }
}
