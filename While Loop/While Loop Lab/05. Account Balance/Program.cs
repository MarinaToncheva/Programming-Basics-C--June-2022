using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double amount = 0;
            while (input != "NoMoreMoney")
            {
                double number=double.Parse(input);
                if (number>=0)
                {
                    amount += number;
                    Console.WriteLine($"Increase: {number:f2}");
                    input = Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }      
            }
            Console.WriteLine($"Total: {amount:f2}");
        } 
     }
}
