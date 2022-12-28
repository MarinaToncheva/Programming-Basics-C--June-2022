using System;

namespace _03._Numbers_1_N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 1; number<=n; number=number+3)
            {
                Console.WriteLine(number);
            }
        }
    }
}
