using System;

namespace _07._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            int litersFuel = int.Parse(Console.ReadLine());
            if (fuel == "Diesel" || fuel == "Gas" || fuel == "Gasoline")
            {
                if (litersFuel >= 25)
                {
                    Console.WriteLine($"You have enough {fuel.ToLower()}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}

