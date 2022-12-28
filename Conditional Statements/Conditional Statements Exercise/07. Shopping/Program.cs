using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberVideoCards = int.Parse(Console.ReadLine());
            int numberProcessors = int.Parse(Console.ReadLine());
            int numberRamMemory = int.Parse(Console.ReadLine());

            double videocardsPrice = numberVideoCards * 250;
            double processorsPrice = numberProcessors * (videocardsPrice * 0.35);
            double ramMemoryPrice = numberRamMemory * (videocardsPrice * 0.10);
            double sumMaterials = videocardsPrice + processorsPrice + ramMemoryPrice;
            if (numberVideoCards > numberProcessors)
            {
                sumMaterials = sumMaterials - (sumMaterials * 0.15);
            }
            else
            {
                sumMaterials = videocardsPrice + processorsPrice + ramMemoryPrice;
            }
            double difference = sumMaterials - budget;
            if (difference <= 0)
            {
                Console.WriteLine($"You have {Math.Abs(difference):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {difference:f2} leva more!");
            }
        }
    }
}
