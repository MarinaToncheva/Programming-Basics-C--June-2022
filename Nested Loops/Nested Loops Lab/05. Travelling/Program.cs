using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double budget = double.Parse(Console.ReadLine());
                double savings = 0;
                while (savings < budget)
                {
                    double money = double.Parse(Console.ReadLine());
                    savings += money;
                }
                Console.WriteLine($"Going to {destination}!");
            }
        }
    }
}
