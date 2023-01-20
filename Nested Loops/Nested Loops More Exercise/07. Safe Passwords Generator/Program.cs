using System;

namespace _07._Safe_Passwords_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int numberOfPasswords = int.Parse(Console.ReadLine());

            int counter = 0;
            int i = 35;
            int j = 64;
            while (i <= 55)
            {
                while (j <= 96)
                {
                    for (int k = 1; k <= firstNumber; k++)
                    {
                        for (int l = 1; l <= secondNumber; l++)

                        {
                            char one = ((char)i);
                            char two = ((char)j);
                            Console.Write($"{one}{two}{k}{l}{two}{one}|");
                            counter++;
                            i++;
                            j++;

                            if (counter >= numberOfPasswords || k == firstNumber && l == secondNumber)
                            {
                                return;
                            }
                            if (i > 55)
                            {
                                i = 35;
                            }
                            if (j > 96)
                            {
                                j = 64;
                            }
                        }
                    }
                }
            }
        }
    }
}
