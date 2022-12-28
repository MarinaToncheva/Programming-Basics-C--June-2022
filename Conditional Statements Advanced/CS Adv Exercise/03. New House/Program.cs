using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            if (flower == "Roses")
            {
                if (numberFlowers <= 80)
                {
                    price = numberFlowers * 5.00;
                }
                else if (numberFlowers > 80)
                {
                    price = numberFlowers * 5.00 - (numberFlowers * 5) * 0.10;
                }
            }
            else if (flower == "Dahlias")
            {
                if (numberFlowers <= 90)
                {
                    price = numberFlowers * 3.80;
                }
                else if (numberFlowers > 90)
                {
                    price = numberFlowers * 3.80 - (numberFlowers * 3.80) * 0.15;
                }
            }
            else if (flower == "Tulips")
            {
                if (numberFlowers <= 80)
                {
                    price = numberFlowers * 2.80;
                }
                else if (numberFlowers > 80)
                {
                    price = numberFlowers * 2.80 - (numberFlowers * 2.80) * 0.15;
                }
            }
            else if (flower == "Narcissus")
            {
                if (numberFlowers >= 120)
                {
                    price = numberFlowers * 3.00;
                }
                else if (numberFlowers < 120)
                {
                    price = numberFlowers * 3.00 + (numberFlowers * 3.00) * 0.15;
                }
            }
            else if (flower == "Gladiolus")
            {
                if (numberFlowers >= 80)
                {
                    price = numberFlowers * 2.50;
                }
                else if (numberFlowers < 80)
                {
                    price = numberFlowers * 2.50 + (numberFlowers * 2.50) * 0.20;
                }
            }
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flower} and {(budget - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(price - budget):f2} leva more.");
            }
        }
    }
}
