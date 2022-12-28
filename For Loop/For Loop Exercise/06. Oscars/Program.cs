using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorsName = Console.ReadLine();
            double points = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string assessorsName = string.Empty;
            double assessorsPoints = 0;

            for (int i = 1; i <= n; i++)
            {
                assessorsName = Console.ReadLine();
                assessorsPoints = double.Parse(Console.ReadLine());
                points += assessorsName.Length * assessorsPoints / 2;
                if (points>=1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }
            if (points<1250.5)
            {
                Console.WriteLine($"Sorry, {actorsName} you need {1250.5-points:f1} more!");
            }
        }
    }
}
