using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double average = 0;
            int counter = 0;
            double all = 0;
            for (int number = 1; number <= n; number++)
            {
                counter++;
                int value = int.Parse(Console.ReadLine());
                all += value;
            }
            average = all / counter;
            Console.WriteLine($"{average:f2}");
        }
    }
}