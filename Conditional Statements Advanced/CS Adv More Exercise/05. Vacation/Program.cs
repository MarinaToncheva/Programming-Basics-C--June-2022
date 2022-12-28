using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double price = 0;
            if (budget<=1000)
            {
                if (season=="Summer")
                {
                    price = budget * 0.65;
                    Console.WriteLine($"Alaska - Camp - {price:f2}");
                }
                else
                {
                    price = budget * 0.45;
                    Console.WriteLine($"Morocco - Camp - {price:f2}");
                }
            }
            else if (budget>1000 && budget<=3000)
            {
                if (season=="Summer")
                {
                    price = budget * 0.80;
                    Console.WriteLine($"Alaska - Hut - {price:f2}");
                }
                else
                {
                    price = budget * 0.60;
                    Console.WriteLine($"Morocco - Hut - {price:f2}");
                }
            }
            else if (budget>3000)
            {
                price = budget * 0.90;
                if (season=="Summer")
                {
                    Console.WriteLine($"Alaska - Hotel - {price:f2}");
                }
                else
                {
                    Console.WriteLine($"Morocco - Hotel - {price:f2}");
                }
            }
        }
    }
}
