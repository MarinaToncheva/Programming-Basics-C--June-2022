using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int space = w * h * l;
            string input = string.Empty;
            int spaceTaken = 0;

            while (input != "Done")
            {
                input = Console.ReadLine();
                if (input == "Done")
                {
                    break;
                }
                int number = int.Parse(input);
                spaceTaken += number;
                if (spaceTaken >= space)
                {
                    Console.WriteLine($"No more free space! You need {spaceTaken - space} Cubic meters more.");
                    break;
                }
            }
            if (space>spaceTaken)
            {
                Console.WriteLine($"{space - spaceTaken} Cubic meters left.");
            }
        }
    }
}