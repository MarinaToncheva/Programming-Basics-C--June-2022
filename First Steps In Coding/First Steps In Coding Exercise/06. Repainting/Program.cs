using System;

namespace _06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine())+2;
            double paint = double.Parse(Console.ReadLine());
            double thinner = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double paintPlus = paint * 0.10;
            double sumNylon = nylon * 1.50;
            double extraPaint = (paint + paintPlus)*14.50;
            double sumThinner = thinner * 5.00;
            double sumMaterials = sumNylon + extraPaint + sumThinner + 0.40;
            double sumCraftsman = (sumMaterials * 0.3) * hours;
            double totalSum = sumMaterials + sumCraftsman;
            Console.WriteLine(totalSum);
        }
    }
}
