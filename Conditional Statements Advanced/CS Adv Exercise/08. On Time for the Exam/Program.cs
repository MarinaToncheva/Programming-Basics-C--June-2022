using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());//10
            int examMin = int.Parse(Console.ReadLine());//10

            int arrivalHour = int.Parse(Console.ReadLine());//10
            int arrivalMin = int.Parse(Console.ReadLine());//0

            examMin = examMin + examHour * 60;
            arrivalMin = arrivalMin + arrivalHour * 60;

            int difference = examMin - arrivalMin; 

            if (difference >= 0 && difference <= 30) 
            {
                Console.WriteLine("On time");
                if (difference != 0)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
            }
            else if (difference > 30)
                {
                    Console.WriteLine("Early");
                    if (difference < 60)
                    {
                        Console.WriteLine($"{difference} minutes before the start");
                    }
                    else
                    {
                        int diffHours = difference / 60;
                        int diffMin = difference % 60;
                        Console.WriteLine($"{diffHours}:{diffMin:d2} hours before the start");
                    }
                }
                else if (difference < 0)
                {
                    Console.WriteLine("Late");
                    difference = Math.Abs(difference);
                    if (difference < 60)
                    {
                        Console.WriteLine($"{difference} minutes after the start");
                    }
                    else
                    {
                        int diffHours = difference / 60;
                        int diffMin = difference % 60;
                        Console.WriteLine($"{diffHours}:{diffMin:d2} hours after the start");
                    }
                }
            }
        }
    }