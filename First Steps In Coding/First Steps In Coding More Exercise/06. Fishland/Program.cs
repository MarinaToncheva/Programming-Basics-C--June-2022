using System;

namespace _06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceМackerel = double.Parse(Console.ReadLine());
            double priceSprat = double.Parse(Console.ReadLine());
            double kilosBonito = double.Parse(Console.ReadLine());
            double kilosHorseMackerel= double.Parse(Console.ReadLine());
            int kilosMussels = int.Parse(Console.ReadLine());

            double priceBonito = priceМackerel + (priceМackerel * 0.60);
            double priceHorseMackerel = priceSprat + (priceSprat * 0.80);
            double priceMussels = 7.50;
            double bonito = kilosBonito * priceBonito;
            double horseMackerel = kilosHorseMackerel * priceHorseMackerel;
            double mussels = kilosMussels * priceMussels;
            double finalBill = bonito + horseMackerel + mussels;

            Console.WriteLine($"{finalBill:f2}");
        }
    }
}
