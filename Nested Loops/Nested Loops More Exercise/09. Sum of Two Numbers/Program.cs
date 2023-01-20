using System;

namespace _09._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber =int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isFound = true;
            for (int i = firstNumber; i <=secondNumber; i++)
            {
                
                for (int j = firstNumber; j <=secondNumber; j++)
                {
                    counter++;
                    if (i+j==magicNumber)
                    {
                        isFound = true;
                    }
                    else
                    {
                        continue;
                    }
                    if (isFound)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
                
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
