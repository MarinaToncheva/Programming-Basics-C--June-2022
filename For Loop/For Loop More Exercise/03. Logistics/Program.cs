using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCargo = int.Parse(Console.ReadLine());
            int all = 0;
            double microbus = 0;
            double truck = 0;
            double train = 0;
            for (int i = 1; i <= numCargo; i++)
            {
                int tons = int.Parse(Console.ReadLine());
                all += tons;
                if (tons <= 3)
                {
                    microbus += tons;
                }
                else if (tons >= 4 && tons <= 11)
                {
                    truck += tons;
                }
                else
                {
                    train += tons;
                }
            }
            double average = (microbus * 200 + truck * 175 + train * 120) / all;
            double percentMicrobus = (microbus / all) * 100;
            double percentTruck = (truck / all) * 100;
            double percentTrain = (train / all) * 100;
            Console.WriteLine($"{average:f2}");
            Console.WriteLine($"{percentMicrobus:f2}%");
            Console.WriteLine($"{percentTruck:f2}%");
            Console.WriteLine($"{percentTrain:f2}%");
        }
    }
}
