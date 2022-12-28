using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePricePerKg = double.Parse(Console.ReadLine());
            double fruitPricePerKg = double.Parse(Console.ReadLine());
            int kgVegetables = int.Parse(Console.ReadLine());
            int kgFruits = int.Parse(Console.ReadLine());
            double income = (vegetablePricePerKg * kgVegetables)+(fruitPricePerKg*kgFruits);
            double incomeInEuro = income / 1.94;
            Console.WriteLine($"{incomeInEuro:f2}");
        }
    }
}
