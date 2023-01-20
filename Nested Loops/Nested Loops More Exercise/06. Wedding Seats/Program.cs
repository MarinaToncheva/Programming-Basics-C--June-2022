using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());
            int factor = 0;
            int counter = 0;
            for (char i = 'A'; i <= lastSector; i++, rows++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (j % 2 == 0)
                    {
                        factor = 2;
                        for (char k = 'a'; k < 'a' + seats + factor; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            counter++;
                        }
                    }
                    else
                    {
                        for (char k = 'a'; k < 'a' + seats; k++)
                        {
                            Console.WriteLine($"{i}{j}{k}");
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
