using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 0;
            int counterPos = 0;
            int counterNeg = 0;
            double sum = 0;
            while (counter < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sum += grade;
                    counterPos++;
                }
                else if (grade < 4)
                {
                    counterNeg++;
                    if (counterNeg == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {counterPos + counterNeg - 1} grade");
                        break;
                    }
                }
                counter++;
            }
         if (counterNeg < 2)
            {
                double average = (sum / 12);
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
