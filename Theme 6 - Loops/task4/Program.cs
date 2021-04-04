using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = "";
            string color = "";
            for(int i = 2; i <=14; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    switch (j)
                    {
                        case 1:
                            color = "spades";
                            break;
                        case 2:
                            color = "diamonds";
                            break;
                        case 3:
                            color = "hearts";
                            break;
                        case 4:
                            color = "clubs";
                            break;
                    }

                    switch (i)
                    {
                        case 2:
                            card = "2";
                            break;
                        case 3:
                            card = "3";
                            break;
                        case 4:
                            card = "4";
                            break;
                        case 5:
                            card = "5";
                            break;
                        case 6:
                            card = "6";
                            break;
                        case 7:
                            card = "7";
                            break;
                        case 8:
                            card = "8";
                            break;
                        case 9:
                            card = "9";
                            break;
                        case 10:
                            card = "10";
                            break;
                        case 11:
                            card = "J";
                            break;
                        case 12:
                            card = "Q";
                            break;
                        case 13:
                            card = "K";
                            break;
                        case 14:
                            card = "A";
                            break;
                    }
                    Console.WriteLine(card + " - " + color);
                }
            }
        }
    }
}
