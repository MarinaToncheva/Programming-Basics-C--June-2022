using System;

namespace _13._Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int firstDifference = int.Parse(Console.ReadLine());
            int secondDifference = int.Parse(Console.ReadLine());

            for (int i = firstNumber; i <= firstNumber+firstDifference; i++)
            {
                for (int j = secondNumber; j<= secondNumber+secondDifference; j++)
                {
                    bool isFirstPrime = true;
                    bool isSecondPrime = true;
                    CheckIfBothArePrime(ref i, ref j, ref isFirstPrime, ref isSecondPrime);

                    if (isFirstPrime && isSecondPrime)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                }
            }
        }

        //    for (int a = firstNumber; a <= firstNumber+firstDifference; a++)
        //    {
        //        for (int b = secondNumber; b <= secondNumber + secondDifference; b++)
        //         {
        //           if (a % 2 != 0 && a % 3 != 0 && a % 5 != 0 && a % 7 != 0 && b % 2 != 0 && b % 3 != 0 && b % 5 != 0 && b % 7 != 0)
        //           {
        //               Console.WriteLine($"{a}{b}");
        //            }
        //         }
        //    }
        public static void CheckIfBothArePrime(ref int i, ref int j, ref bool isFirstPrime, ref bool isSecondPrime)
        {
            for (int k = 2; i <= Math.Sqrt(i); i++)
            {
                if (i % k == 0)
                {
                    isFirstPrime = false;
                    break;
                }
            }
            for (int l = 2; l <= Math.Sqrt(j); l++)
            {
                if (j % l == 0)
                {
                    isSecondPrime = false;
                    break;
                }
            }
        }
    }
}
