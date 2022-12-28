using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double spentMoney = 12000;
            
            for (int i = 1800; i <= year; i++)
            {
                if (i%2==0)
                {
                    inheritedMoney = inheritedMoney - spentMoney;
                }
                if (i%2!=0)
                {
                    inheritedMoney=inheritedMoney - (spentMoney + 50 * (i + 18 - 1800));
                }
            }
            if (inheritedMoney<0)
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):f2} dollars to survive.");
            }
            else if (inheritedMoney>=0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:f2} dollars left.");
            }
        }
    }
}
