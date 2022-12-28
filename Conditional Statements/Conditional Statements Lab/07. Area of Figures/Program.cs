using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure =Console.ReadLine();
            if (figure == "square")
            {
                double lenght = double.Parse(Console.ReadLine());
                double sSquare = lenght * lenght;
                Console.WriteLine($"{ sSquare:F3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double sRectangle = a * b;
                Console.WriteLine($"{ sRectangle:F3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double sCircle = r*r*Math.PI;
                Console.WriteLine($"{ sCircle:F3}");
            }
            else if (figure == "triangle")
            {
                double aTriangle = double.Parse(Console.ReadLine());
                double hTriangle = double.Parse(Console.ReadLine());
                double sTriangle = (aTriangle*hTriangle)/2.0;
                Console.WriteLine($"{ sTriangle:F3}");
            }
        }
    }
}
