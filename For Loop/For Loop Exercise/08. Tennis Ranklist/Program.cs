using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournament = int.Parse(Console.ReadLine());
            int startUpPoints = int.Parse(Console.ReadLine());
            int W = 2000;
            int F = 1200;
            int SF = 720;
            int finalPoints = 0 + startUpPoints;
            double wCount = 0;
            for (int i = 1; i <= tournament; i++)
            {
                string position = Console.ReadLine();
                if (position == "W")
                {
                    finalPoints += W;
                    wCount += 1;
                }
                if (position == "F")
                {
                    finalPoints += F;
                }
                if (position == "SF")
                {
                    finalPoints += SF;
                }
            }
            double average = (finalPoints-startUpPoints) / tournament;
            double percent = (wCount / tournament) * 100.0;
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(average)}");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
