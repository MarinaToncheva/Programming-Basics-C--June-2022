using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberPeople = int.Parse(Console.ReadLine());
            double pricePerOnePerson = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double costsOutfit = numberPeople * pricePerOnePerson;
            if (numberPeople > 150)
            {
                costsOutfit=costsOutfit-(costsOutfit*0.10);
            }
            else
            {
                costsOutfit = numberPeople * pricePerOnePerson;
            }
            double finalBill = decor + costsOutfit;

            if (finalBill>budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(finalBill-budget):f2} leva more.");   
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget-finalBill):f2} leva left.");
            }
        }
    }
}
