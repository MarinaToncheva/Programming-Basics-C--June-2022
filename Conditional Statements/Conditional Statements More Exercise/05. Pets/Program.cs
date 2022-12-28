using System;

namespace _05._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftFoodInKilos = int.Parse(Console.ReadLine());
            double foodDogForOneDay = double.Parse(Console.ReadLine());
            double foodCatForOneDay = double.Parse(Console.ReadLine());
            double foodTurtleForOneDay = double.Parse(Console.ReadLine());

            double neededFoodForDog = foodDogForOneDay * days;
            double neededFoodForCat = foodCatForOneDay * days;
            double neededFoodForTurtle = (foodTurtleForOneDay / 1000) * days;
            double allFood = neededFoodForDog + neededFoodForCat + neededFoodForTurtle;
            if (allFood<=leftFoodInKilos)
            {
                Console.WriteLine($"{Math.Floor(leftFoodInKilos-allFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(allFood-leftFoodInKilos)} more kilos of food are needed.");
            }
        }
    }
}
