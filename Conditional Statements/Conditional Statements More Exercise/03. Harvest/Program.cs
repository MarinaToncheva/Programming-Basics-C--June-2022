using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int numberWorkers = int.Parse(Console.ReadLine());
            double metresForWine = x * 0.40;
            double kilosNeeded = metresForWine * y;
            double wine = kilosNeeded / 2.5;
            if (wine < z)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(z-wine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine-z)} liters left -> {Math.Ceiling(((wine-z)/numberWorkers))} liters per person.");
            }
        }
    }
}
