using System;

namespace _05._Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double points = 0;
            double first = 0;
            double second = 0;
            double third = 0;
            double fourth = 0;
            double fifth = 0;
            double sixth = 0;
            double percentFirst = 0;
            double percentSecond = 0;
            double percentThird = 0;
            double percentFourth = 0;
            double percentFifth = 0;
            double percentSixth = 0;

            for (int i = 1; i <= moves; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers >= 0 && numbers <= 9)
                {
                    points += numbers * 0.20;
                    first += 1;
                }
                else if (numbers >= 10 && numbers <= 19)
                {
                    points += numbers * 0.30;
                    second += 1;
                }
                else if (numbers >= 20 && numbers <= 29)
                {
                    points += numbers * 0.40;
                    third += 1;
                }
                else if (numbers >= 30 && numbers <= 39)
                {
                    points = points + 50.0;
                    fourth += 1;
                }
                else if (numbers >= 40 && numbers <= 50)
                {
                    points = points + 100.0;
                    fifth += 1;
                }
                else if (numbers < 0 || numbers > 50)
                {
                    points = points / 2;
                    sixth += 1;
                }
            }
            percentFirst = (first / moves) * 100.0;
            percentSecond = (second / moves) * 100.0;
            percentThird = (third / moves) * 100.0;
            percentFourth = (fourth / moves) * 100.0;
            percentFifth = (fifth / moves) * 100.0;
            percentSixth = (sixth / moves) * 100.0;

            Console.WriteLine($"{points:f2}");
            Console.WriteLine($"From 0 to 9: {percentFirst:f2}%");
            Console.WriteLine($"From 10 to 19: {percentSecond:f2}%");
            Console.WriteLine($"From 20 to 29: {percentThird:f2}%");
            Console.WriteLine($"From 30 to 39: {percentFourth:f2}%");
            Console.WriteLine($"From 40 to 50: {percentFifth:f2}%");
            Console.WriteLine($"Invalid numbers: {percentSixth:f2}%");
        }
    }
}
