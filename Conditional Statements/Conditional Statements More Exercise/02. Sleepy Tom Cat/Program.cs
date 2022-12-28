using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int restDays = int.Parse(Console.ReadLine());

            int minutesInWorkingDays = (365 - restDays) * 63;
            int minutesInRestDays = restDays * 127;
            int allMinutes = minutesInRestDays + minutesInWorkingDays;
            int hours = allMinutes / 60;
            int minutes = allMinutes % 60;
            int remainingMinutes = 30000 - allMinutes;
            int hoursRemaining = remainingMinutes / 60;
            int minutesRemaining = remainingMinutes % 60;
            if (allMinutes > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs(hoursRemaining)} hours and {Math.Abs(minutesRemaining)} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hoursRemaining} hours and {minutesRemaining} minutes less for play");
            }
        }
    }
}
