using System;

namespace _01._Trapeziod_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBasis = double.Parse(Console.ReadLine());
            double secondBasis = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double s = (firstBasis + secondBasis) * h / 2;
            Console.WriteLine($"{s:F2}");
        }
    }
}
