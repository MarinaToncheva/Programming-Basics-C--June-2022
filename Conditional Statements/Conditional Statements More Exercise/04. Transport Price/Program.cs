using System;

namespace hmm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberKilometers = int.Parse(Console.ReadLine());
            string timeTravel = Console.ReadLine();
            double price = 0;
            double taxiRate = 0;
            if (timeTravel == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.90;
            }
            if (numberKilometers < 20)
            {
                price = 0.70 + numberKilometers * taxiRate;
            }
            else if (numberKilometers < 100)
            {
                price = numberKilometers * 0.09;
            }
            else
            {
                price = numberKilometers * 0.06;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
