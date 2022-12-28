using System;

namespace _10._Clock___part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h < 24; h++)
            {
                for (int min = 0; min < 60; min++)
                {
                    for (int sec = 0; sec < 60; sec++)
                    {
                        Console.WriteLine($"{h} : {min} : {sec}");
                    }
                }
            }
        }
    }
}
