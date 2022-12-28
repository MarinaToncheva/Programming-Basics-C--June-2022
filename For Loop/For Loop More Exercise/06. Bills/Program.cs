using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            double finallBill = 0;
            double water = 0;
            double internet = 0;
            double other = 0;
            double average = 0;
                
            for (int i = 1; i <= months; i++)
            {
                double bill = double.Parse(Console.ReadLine());
                finallBill = finallBill + bill;
            }
            water = months * 20.0;
            internet = months * 15.0;
            other = (water + internet + finallBill) + (water + internet + finallBill) * 0.20;
            average = (water + internet + finallBill + other) / months;
            Console.WriteLine($"Electricity: {finallBill:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
