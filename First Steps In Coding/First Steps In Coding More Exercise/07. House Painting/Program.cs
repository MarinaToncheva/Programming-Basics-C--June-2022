using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double firstSquareArea = x * x;
            double secondSquareArea = x * x - (2 * 1.2);
            double firstRectangleArea = x * y - (1.5 * 1.5);
            double secondRectangleArea = firstRectangleArea;
            double roofArea = 2*(x*y)+2*((x*h)/2);
            double allHouse = firstSquareArea + secondSquareArea + firstRectangleArea + secondRectangleArea;
            double greenPaint = allHouse / 3.4;
            double redPaint = roofArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
