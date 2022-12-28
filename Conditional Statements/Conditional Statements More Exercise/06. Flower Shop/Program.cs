using System;

namespace _06._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int rosess = int.Parse(Console.ReadLine());
            int cacti = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double allMagnolias = 3.25 * magnolias;
            double allHyacinths = 4.0 * hyacinths;
            double allRoses = 3.50 * rosess;
            double allCacti = 8.0 * cacti;
            double allFlowersPrice = allMagnolias + allHyacinths + allRoses + allCacti;
            double taxes = allFlowersPrice * 0.05;
            double moneyLeftForPresent = allFlowersPrice - taxes;

            if (moneyLeftForPresent < presentPrice)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - moneyLeftForPresent)} leva.");
            }
            else
            {
                Console.WriteLine($"She is left with {Math.Floor(moneyLeftForPresent-presentPrice)} leva.");
            }
        }
    }
}
