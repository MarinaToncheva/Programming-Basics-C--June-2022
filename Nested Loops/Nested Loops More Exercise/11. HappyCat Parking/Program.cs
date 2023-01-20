using System;

namespace _11._HappyCat_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());
            double sum = 0;
            double currentDaySum = 0;
            for (int i = 1; i <=days; i++)
            {
                currentDaySum = 0;
                for (int j = 1; j <=hoursPerDay; j++)
                {
                    if (i%2==0 && j%2!=0)
                    {
                        currentDaySum += 2.5;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        currentDaySum += 1.25;
                    }
                    else
                    {
                        currentDaySum += 1.0;
                    }
                }
                sum += currentDaySum;
                Console.WriteLine($"Day: {i} - {currentDaySum:f2} leva");
            }
            Console.WriteLine($"Total: {sum:f2} leva");
        }
    }
}
