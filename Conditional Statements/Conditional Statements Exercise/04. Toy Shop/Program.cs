using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int toysQuantity = puzzles + dolls + bears + minions + trucks;
            double money = puzzles*2.60 + dolls*3.00 + bears*4.10 + minions*8.20 + trucks*2.00;
            if (toysQuantity>=50)
            {
                money = money - (money * 0.25);
            }
            money = money - money * 0.10;
            double difference = excursionPrice - money;

            if (difference<=0)
            {
                Console.WriteLine($"Yes! {Math.Abs(difference):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {difference:f2} lv needed.");
            }
        }
    }
}
