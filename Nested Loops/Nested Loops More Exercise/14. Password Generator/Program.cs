using System;

namespace _14._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberN = int.Parse(Console.ReadLine());
            int secondNumberL = int.Parse(Console.ReadLine());

            char input = ((char)(secondNumberL));
            for (int i = 1; i < firstNumberN; i++)
            {
                for (int j = 1; j < firstNumberN; j++)
                {
                    for (int k = 97; k < 97+secondNumberL; k++)
                    {
                        for (int l = 97; l < 97+secondNumberL; l++)
                        {
                            for (int m = 2; m <= firstNumberN; m++)
                            {
                                if (m>i && m>j)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)l}{m} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}