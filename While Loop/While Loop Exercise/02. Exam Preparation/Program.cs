using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedTimes = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int evaluationCount = 0;
            int failedCount = 0;
            double evaluationSum = 0;
            string lastExercise = string.Empty;
            double evaluation;

            while (input!="Enough")
            {
                lastExercise = input;
                evaluation = double.Parse(Console.ReadLine());

                evaluationSum += evaluation;
                evaluationCount++;

                if (evaluation<=4)
                {
                    failedCount++;
                    if (failedCount==failedTimes)
                    {
                        Console.WriteLine($"You need a break, {failedTimes} poor grades.");
                        break;
                    }
                }
                input = Console.ReadLine();
            }
            if (input=="Enough")
            {
                Console.WriteLine($"Average score: {evaluationSum/evaluationCount:f2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");
            }
        }
    }
}
