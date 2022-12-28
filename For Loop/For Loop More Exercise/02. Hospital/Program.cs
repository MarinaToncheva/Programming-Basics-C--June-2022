using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int examined = 0;
            int unExamined = 0;
            int doctors = 7;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if ((i%3==0) && unExamined > examined)
                {
                    doctors++;
                }
                if (patients>doctors)
                {
                    examined += doctors;
                    unExamined += patients - doctors;
                }
                else
                {
                    examined += patients;
                }
                
            }
            Console.WriteLine($"Treated patients: {examined}.");
            Console.WriteLine($"Untreated patients: {unExamined}.");
        }
    }
}
