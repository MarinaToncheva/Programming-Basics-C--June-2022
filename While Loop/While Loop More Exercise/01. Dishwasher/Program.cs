using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBottles = int.Parse(Console.ReadLine());
            int quantityDetergent=numBottles*750;
            string dishes = "";
            int counter = 0;
            int detergentForPlate = 5;
            int detergentForPot = 15;
            int plateCount = 0;
            int potCount = 0;



            while (quantityDetergent >= 0 && (dishes = Console.ReadLine()) != "End")
            {
                counter++;
                
                int numDishes = int.Parse(dishes);

                if (counter == 3)
                {
                    potCount += numDishes;
                    numDishes *= detergentForPot;
                    quantityDetergent -= numDishes;
                    counter = 0;
                }
                else
                {
                    plateCount += numDishes;
                    numDishes *= detergentForPlate;
                    quantityDetergent -= numDishes;
                }
            }
         if (quantityDetergent >= 0)
                {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{plateCount} dishes and {potCount} pots were washed.");
                Console.WriteLine($"Leftover detergent {quantityDetergent} ml.");
                }
                else
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(quantityDetergent)} ml. more necessary!");
                }
            
            }
        }
    }

