using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            string input = Console.ReadLine();
            while (input!="Stop")
            {
                int number = int.Parse(input);
             if (number>max)
                {
                    max = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
