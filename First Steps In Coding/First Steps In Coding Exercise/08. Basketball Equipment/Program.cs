using System;

namespace _08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTax = int.Parse(Console.ReadLine());
            double sneakers = yearTax - (yearTax * 0.40);
            double outfit = sneakers - (sneakers * 0.20);
            double ball = outfit / 4;
            double accessories = ball / 5;
            double allExpenses = yearTax + sneakers + outfit + ball + accessories;
            Console.WriteLine(allExpenses);
        }
    }
}
