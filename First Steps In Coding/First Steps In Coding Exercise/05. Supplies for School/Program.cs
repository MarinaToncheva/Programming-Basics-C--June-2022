using System;

namespace _05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPackagePens = int.Parse(Console.ReadLine());
            int numberPackageMarkers = int.Parse(Console.ReadLine());
            int litres = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double sum = (numberPackagePens * 5.80 + numberPackageMarkers * 7.20 + litres * 1.20);
            double sumWithDiscount = sum - (sum * (percent / 100));
            Console.WriteLine(sumWithDiscount);
        }
    }
}
