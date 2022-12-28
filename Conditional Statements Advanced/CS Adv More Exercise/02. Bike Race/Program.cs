using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberJuniors = int.Parse(Console.ReadLine());
            int numberSeniors = int.Parse(Console.ReadLine());
            string route = Console.ReadLine();
            double collectedAmount = 0;
            double costs = 0;
            double moneyLeft = 0;
            switch (route)
            {
                case "trail":
                    collectedAmount = numberJuniors * 5.50 + numberSeniors * 7.0;
                    costs = collectedAmount * 0.05;
                    moneyLeft = collectedAmount - costs;
                    Console.WriteLine($"{moneyLeft:f2}");
                    break;
                case "cross-country":
                    if ((numberJuniors+numberSeniors)>=50)
                    {
                        collectedAmount = (numberJuniors * 8.0 + numberSeniors * 9.5)- ((numberJuniors * 8.0 + numberSeniors * 9.50)*0.25);
                        costs = collectedAmount * 0.05;
                        moneyLeft = collectedAmount - costs;
                        Console.WriteLine($"{moneyLeft:f2}");
                    }
                    else
                    {
                       collectedAmount = numberJuniors * 8.0 + numberSeniors * 9.5;
                        costs = collectedAmount * 0.05;
                        moneyLeft = collectedAmount - costs;
                        Console.WriteLine($"{moneyLeft:f2}");
                    }
                    break;
                case "downhill":
                    collectedAmount = numberJuniors * 12.25 + numberSeniors * 13.75;
                    costs = collectedAmount * 0.05;
                    moneyLeft = collectedAmount - costs;
                    Console.WriteLine($"{moneyLeft:f2}");
                    break;
                case "road":
                    collectedAmount = numberJuniors * 20.0 + numberSeniors * 21.50;
                    costs = collectedAmount * 0.05;
                    moneyLeft = collectedAmount - costs;
                    Console.WriteLine($"{moneyLeft:f2}");
                    break;
            }
        }
    }
}
