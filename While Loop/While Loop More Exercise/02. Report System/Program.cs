using System;

namespace _02._Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededMoney = int.Parse(Console.ReadLine());
            string amount = string.Empty;
            int transCount = 0;
            int counter = 0;
            double transCashCount = 0;
            double transPosCount = 0;
            double cashAverage = 0;
            double PosAverage = 0;
            int counterCash = 0;
            int counterPos = 0;

            while (transCount < neededMoney && (amount = Console.ReadLine()) != "End")
            {
                counter++;
                int input = int.Parse(amount);

                if (counter % 2 != 0 && input <= 100)
                {
                    counterCash++;
                    transCount += input;
                    transCashCount += input;
                    Console.WriteLine("Product sold!");
                    continue;
                }
                else if (counter % 2 != 0 && input > 100)
                {
                    Console.WriteLine("Error in transaction!");
                    continue;
                }
                if (counter % 2 == 0 && input >= 10)
                {
                    counterPos++;
                    transCount += input;
                    transPosCount += input;
                    Console.WriteLine("Product sold!");
                }
                else
                {
                    Console.WriteLine("Error in transaction!");
                    continue;
                }

            }
            if (amount == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
                return;
            }
            cashAverage = transCashCount / counterCash;
            PosAverage = transPosCount / counterPos;

            Console.WriteLine($"Average CS: {cashAverage:f2}");
            Console.WriteLine($"Average CC: {PosAverage:f2}");
        }
    }
}
