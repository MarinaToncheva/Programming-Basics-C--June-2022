using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            double topStudents = 0;
            double groupOne = 0;
            double groupTwo = 0;
            double fail = 0;
            double all = 0;
            double average = 0;
            double percentOne = 0;
            double percentTwo = 0;
            double percentThree = 0;
            double percentFour = 0;

            for (int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 5.00)
                {
                    topStudents = topStudents + 1;
                    all = all + grade;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    groupOne = groupOne + 1;
                    all = all + grade;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    groupTwo = groupTwo + 1;
                    all = all + grade;
                }
                else if (grade < 3.00)
                {
                    fail = fail + 1;
                    all = all + grade;
                }
            }
            average = all / students;
            percentOne=(topStudents/students)*100.00;
            percentTwo = (groupOne / students) * 100.00;
            percentThree = (groupTwo / students) * 100.00;
            percentFour = (fail / students) * 100.00;

            Console.WriteLine($"Top students: {percentOne:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentTwo:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentThree:f2}%");
            Console.WriteLine($"Fail: {percentFour:f2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
