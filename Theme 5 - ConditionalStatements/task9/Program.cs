﻿using System;

namespace Chapter_5_Solution_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            sbyte first = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter second number: ");
            sbyte second = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter third number: ");
            sbyte third = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            sbyte fourth = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            sbyte fifth = Convert.ToSByte(Console.ReadLine());

            if (first == 0)
                Console.WriteLine("{0} = 0", first);
            if (second == 0)
                Console.WriteLine("{0} = 0", second);
            if (third == 0)
                Console.WriteLine("{0} = 0", third);
            if (fourth == 0)
                Console.WriteLine("{0} = 0", fourth);
            if (fifth == 0)
                Console.WriteLine("{0} = 0", fifth);
            if (first + second == 0)
                Console.WriteLine("{0}+ {1} = 0", first, second);
            if (first + third == 0)
                Console.WriteLine("{0}+ {1} = 0", first, third);
            if (first + fourth == 0)
                Console.WriteLine("{0}+ {1} = 0", first, fourth);
            if (first + fifth == 0)
                Console.WriteLine("{0}+ {1} = 0", first, fifth);
            if (second + third == 0)
                Console.WriteLine("{0}+ {1} = 0", second, third);
            if (second + fourth == 0)
                Console.WriteLine("{0}+ {1} = 0", second, fourth);
            if (second + fifth == 0)
                Console.WriteLine("{0}+ {1} = 0", second, fifth);
            if (third + fourth == 0)
                Console.WriteLine("{0}+ {1} = 0", third, fourth);
            if (third + fifth == 0)
                Console.WriteLine("{0}+ {1} = 0", third, fifth);
            if (fourth + fifth == 0)
                Console.WriteLine("{0}+ {1} = 0", fourth, fifth);
            if (first + second + third == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, third);
            if (first + second + fourth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, fourth);
            if (first + second + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, fifth);
            if (first + third + fourth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, third, fourth);
            if (first + third + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, third, fifth);
            if (first + fourth + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, fourth, fifth);
            if (second + third + fourth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", second, third, fourth);
            if (second + third + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", second, third, fifth);
            if (second + fourth + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", second, fourth, fifth);
            if (third + fourth + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", third, fourth, fifth);
            if (first + second + third + fourth == 0)
                Console.WriteLine("{0}+ {1}+ {2}+ {3} = 0", first, second, third, fourth);
            if (first + second + third + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2}+ {3} = 0", first, second, third, fifth);
            if (first + second + fourth + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2}+ {3} = 0", first, second, fourth, fifth);
            if (first + third + fourth + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2}+ {3} = 0", first, third, fourth, fifth);
            if (second + third + fourth + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2}+ {3} = 0", second, third, fourth, fifth);
            Console.ReadLine();
        }
    }
}