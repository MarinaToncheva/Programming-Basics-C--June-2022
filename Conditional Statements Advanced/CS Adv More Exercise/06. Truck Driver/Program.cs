using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());
            double salary = 0;
            switch (season)
            {
                case"Spring":
                case "Autumn":
                    if (kmPerMonth<=5000)
                    {
                        salary = (kmPerMonth * 0.75) * 4 - ((kmPerMonth * 0.75) * 4) * 0.10;
                    }
                    else if (kmPerMonth>5000 && kmPerMonth<=10000)
                    {
                        salary = (kmPerMonth * 0.95) * 4 - ((kmPerMonth * 0.95) * 4) * 0.10;
                    }
                    else if (kmPerMonth>10000 && kmPerMonth<=20000)
                    {
                        salary = (kmPerMonth * 1.45) * 4 - ((kmPerMonth * 1.45) * 4) * 0.10;
                    }
                    Console.WriteLine($"{salary:f2}");
                    break;

                case "Summer":
                    if (kmPerMonth <= 5000)
                    {
                        salary = (kmPerMonth * 0.90) * 4 - ((kmPerMonth * 0.90) * 4) * 0.10;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        salary = (kmPerMonth * 1.10) * 4 - ((kmPerMonth * 1.10) * 4) * 0.10;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        salary = (kmPerMonth * 1.45) * 4 - ((kmPerMonth * 1.45) * 4) * 0.10;
                    }
                    Console.WriteLine($"{salary:f2}");
                    break;
                default:
                    if (kmPerMonth <= 5000)
                    {
                        salary = (kmPerMonth * 1.05) * 4 - ((kmPerMonth * 1.05) * 4) * 0.10;
                    }
                    else if (kmPerMonth > 5000 && kmPerMonth <= 10000)
                    {
                        salary = (kmPerMonth * 1.25) * 4 - ((kmPerMonth * 1.25) * 4) * 0.10;
                    }
                    else if (kmPerMonth > 10000 && kmPerMonth <= 20000)
                    {
                        salary = (kmPerMonth * 1.45) * 4 - ((kmPerMonth * 1.45) * 4) * 0.10;
                    }
                    Console.WriteLine($"{salary:f2}");
                    break;
            }
        }
    }
}
