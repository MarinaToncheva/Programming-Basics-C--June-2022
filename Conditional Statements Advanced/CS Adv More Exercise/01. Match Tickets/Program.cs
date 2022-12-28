using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int numberPeople = int.Parse(Console.ReadLine());

            double moneyForTransport = 0;
            double moneyLeftForTicket = 0;
            double neededMoney = 0;

            if (numberPeople >= 1 && numberPeople <= 4)
            {
                moneyForTransport = budget * 0.75;
                moneyLeftForTicket = budget - moneyForTransport;
                if (category == "VIP")
                {
                    neededMoney = numberPeople * 499.99;
                }
                else
                {
                    neededMoney = numberPeople * 249.99;
                }
            }
            else if (numberPeople >= 5 && numberPeople <= 9)
            {
                moneyForTransport = budget * 0.60;
                moneyLeftForTicket = budget - moneyForTransport;
                if (category == "VIP")
                {
                    neededMoney = numberPeople * 499.99;
                }
                else
                {
                    neededMoney = numberPeople * 249.99;
                }
            }
            else if (numberPeople >= 10 && numberPeople <= 24)
            {
                moneyForTransport = budget * 0.50;
                moneyLeftForTicket = budget - moneyForTransport;
                if (category == "VIP")
                {
                    neededMoney = numberPeople * 499.99;
                }
                else
                {
                    neededMoney = numberPeople * 249.99;
                }
            }
            else if (numberPeople >= 25 && numberPeople <= 49)
            {
                moneyForTransport = budget * 0.40;
                moneyLeftForTicket = budget - moneyForTransport;
                if (category == "VIP")
                {
                    neededMoney = numberPeople * 499.99;
                }
                else
                {
                    neededMoney = numberPeople * 249.99;
                }
            }
            else if (numberPeople >= 50)
            {
                moneyForTransport = budget * 0.25;
                moneyLeftForTicket = budget - moneyForTransport;
                if (category == "VIP")
                {
                    neededMoney = numberPeople * 499.99;
                }
                else
                {
                    neededMoney = numberPeople * 249.99;
                }
            }
            if (moneyLeftForTicket >= neededMoney)
            {
                Console.WriteLine($"Yes! You have {Math.Abs((neededMoney - moneyLeftForTicket)):f2} leva left.");
            }
            else if (moneyLeftForTicket < neededMoney)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs((neededMoney - moneyLeftForTicket)):f2} leva.");
            }
        }
    }
}