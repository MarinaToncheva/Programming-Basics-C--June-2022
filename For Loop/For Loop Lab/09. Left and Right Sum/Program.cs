using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                leftSum += value;
            }
            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());
                rightSum += value;
            }
            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(rightSum - leftSum)}");
            }
        }
    }
}
