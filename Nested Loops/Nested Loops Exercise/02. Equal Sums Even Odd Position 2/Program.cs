using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            for (int i = num1; i <= num2; i++)
            {
                int oddSum = 0;
                int evenSum = 0;

                string currentNum = i.ToString();
                for (int j = 0; j <= 5; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSum += currentNum[j];
                    }
                    else
                    {
                        oddSum += currentNum[j];
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(currentNum + " ");
                }
            }
        }
    }
}
