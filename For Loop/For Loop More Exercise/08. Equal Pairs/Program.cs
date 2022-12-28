using System;

namespace _08._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumbers = int.Parse(Console.ReadLine());
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            int currentDifference = 0;
            int currentSum = 0;
            bool isEqual = true;

            for (int i = 0; i < countNumbers - 1; i++)
            {
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
                currentSum = firstNumber + secondNumber;

                if (currentSum != sum)
                {
                    int difference = Math.Abs(currentSum - sum);
                    if (difference > currentDifference)
                    {
                        currentDifference = difference;
                    }
                    sum = currentSum
                        ;
                    isEqual = false;
                }
            }
            if (isEqual)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={currentDifference}");
            }
        }
    }
}
