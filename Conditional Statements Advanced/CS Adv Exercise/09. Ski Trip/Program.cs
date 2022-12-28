using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysInHotel = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();
            double price = 0;
            double finalPrice = 0;
            if (roomType == "room for one person")
            {
                price = (daysInHotel - 1) * 18.0;
                if (daysInHotel < 10)
                {
                    if (grade == "positive")
                    {
                        finalPrice = price + (0.25 * price);
                    }
                    else
                    {
                        finalPrice = price - (0.10 * price);
                    }
                }
                else if (daysInHotel == 10 || daysInHotel <= 15)
                {
                    if (grade == "positive")
                    {
                        finalPrice = price + (0.25 * price);
                    }
                    else
                    {
                        finalPrice = price - (0.10 * price);
                    }
                }
                else if (daysInHotel > 15)
                {
                    if (grade == "positive")
                    {
                        finalPrice = price + (0.25 * price);
                    }
                    else
                    {
                        finalPrice = price - (0.10 * price);
                    }
                }
                Console.WriteLine($"{(finalPrice):f2}");
            }
            else if (roomType == "apartment")
            {
                double finalPriceOne = 0;
                double finalPriceTwo = 0;
                price = (daysInHotel - 1) * 25.0;
                if (daysInHotel < 10)
                {
                    if (grade == "positive")
                    {
                        finalPriceOne = price - (0.30 * price);
                        finalPriceTwo = finalPriceOne + (0.25 * finalPriceOne);
                    }
                    else
                    {
                        finalPriceOne = price - (0.30 * price);
                        finalPriceTwo = finalPriceOne - (0.10 * finalPriceOne);
                    }
                }
                else if (daysInHotel == 10 || daysInHotel <= 15)
                {
                    if (grade == "positive")
                    {
                        finalPriceOne = price - (0.35 * price);
                        finalPriceTwo = finalPriceOne + (0.25 * finalPriceOne);
                    }
                    else
                    {
                        finalPriceOne = price - (0.35 * price);
                        finalPriceTwo = finalPriceOne - (0.10 * finalPriceOne);
                    }
                }
                else if (daysInHotel > 15)
                {
                    if (grade == "positive")
                    {
                        finalPriceOne = price - (0.50 * price);
                        finalPriceTwo = finalPriceOne + (0.25 * finalPriceOne);
                    }
                    else
                    {
                        finalPriceOne = price - (0.50 * price);
                        finalPriceTwo = finalPriceOne - (0.10 * finalPriceOne);
                    }
                }
                Console.WriteLine($"{(finalPriceTwo):f2}");
            }
            else if (roomType=="president apartment")
            {
                price = (daysInHotel - 1) * 35.0;
                double finalPriceOne = 0;
                double finalPriceTwo = 0;
                if (daysInHotel < 10)
                {
                    if (grade == "positive")
                    {
                        finalPriceOne  = price - (0.10 * price);
                        finalPriceTwo = finalPriceOne + (0.25 * finalPriceOne);
                    }
                    else
                    {
                        finalPriceOne = price - (0.10 * price);
                        finalPriceTwo = finalPriceOne - (0.10 * finalPriceOne);
                    }
                }
                else if (daysInHotel == 10 || daysInHotel <= 15)
                {
                    if (grade == "positive")
                    {
                        finalPriceOne = price - (0.15 * price);
                        finalPriceTwo = finalPriceOne + (0.25 * finalPriceOne);
                    }
                    else
                    {
                        finalPriceOne = price - (0.15 * price);
                        finalPriceTwo = finalPriceOne - (0.10 * finalPriceOne);
                    }
                }
                else if (daysInHotel > 15)
                {
                    if (grade == "positive")
                    {
                        finalPriceOne = price - (0.20 * price);
                        finalPriceTwo = finalPriceOne + (0.25 * finalPriceOne);
                    }
                    else
                    {
                        finalPriceOne = price - (0.20 * price);
                        finalPriceTwo = finalPriceOne - (0.10 * finalPriceOne);
                    }
                }
                Console.WriteLine($"{(finalPriceTwo):f2}");
            }
        }
    }
}
