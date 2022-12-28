using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            double numA = 0;
            double numB = 0;
            double numV = 0;
            double numG = 0;
            double all = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();
                if (sector=="A")
                {
                    numA++;
                }
                else if (sector=="B")
                {
                    numB++;
                }
                else if (sector=="V")
                {
                    numV++;
                }
                else if (sector=="G")
                {
                    numG++;
                }
            }
            all = numA + numB + numV + numG;

            double percentA=(numA/all)*100.0;
            double percentB= (numB / all) * 100.0;
            double percentV= (numV / all) * 100.0;
            double percentG= (numG / all) * 100.0;
            double percent= (all / capacity) * 100.0;

            Console.WriteLine($"{percentA:f2}%");
            Console.WriteLine($"{percentB:f2}%");
            Console.WriteLine($"{percentV:f2}%");
            Console.WriteLine($"{percentG:f2}%");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}