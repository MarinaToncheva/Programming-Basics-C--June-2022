using System;

namespace _01._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumBorder = int.Parse(Console.ReadLine());
            int secondNumBorder = int.Parse(Console.ReadLine());
            int thirdNumBorder = int.Parse(Console.ReadLine());

            for (int first = 1; first <= firstNumBorder; first++)
            {
                if (first%2==0)
                {
                    for (int second = 2; second <= secondNumBorder; second++)
                    {
                        if (second==2 || second == 3 || second == 5 || second == 7)
                        {
                            for (int third = 1; third <= thirdNumBorder; third++)
                            {
                                if (third%2==0)
                                {
                                    Console.WriteLine($"{first} {second} {third}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
