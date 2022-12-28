using System;

namespace _02._Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBasis = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double s = firstBasis* h / 2;
            Console.WriteLine($"{s:F2}");
        }
    }
}
