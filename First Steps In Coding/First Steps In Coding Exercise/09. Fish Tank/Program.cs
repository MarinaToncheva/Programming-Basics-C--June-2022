using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = lenght * width * height;
            double volumeInLitres = volume / 1000.0;
            double finalVolume = volumeInLitres - (volumeInLitres * (percent / 100.0));
            Console.WriteLine(finalVolume);
        }
    }
}
