using System;

namespace _12._The_Song_of_the_Wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            int winningA = 0;
            int winningB = 0;
            int winningC = 0;
            int winningD = 0;
            bool isFound = false;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 2; b <= 9; b++)
                {
                    if (a < b)
                    {
                        for (int c = 2; c <= 9; c++)
                        {
                            for (int d = 1; d <= 9; d++)
                            {
                                if (c > d)
                                {
                                    if (a * b + c * d == number)
                                    {
                                        isFound = true;
                                        counter++;
                                        if (counter == 4)
                                        {
                                            winningA = a;
                                            winningB = b;
                                            winningC = c;
                                            winningD = d;
                                            Console.Write($"{a}{b}{c}{d} ");
                                        }
                                        else
                                        {
                                            Console.Write($"{a}{b}{c}{d} ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (isFound==false)
            {
                Console.WriteLine("No!");
            }
            else
            {
                Console.WriteLine();
                if (counter < 4)
                {
                    Console.WriteLine("No!");
                }
                else
                {
                    Console.WriteLine($"Password: {winningA}{winningB}{winningC}{winningD}");
                }
            }
        }
    }
}