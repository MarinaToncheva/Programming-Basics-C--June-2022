using System;

namespace _07._Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberChickenMenu = int.Parse(Console.ReadLine());
            int numberFishMenu = int.Parse(Console.ReadLine());
            int numberVegMenu = int.Parse(Console.ReadLine());

            double priceChickenMenu = numberChickenMenu * 10.35;
            double priceFishMenu = numberFishMenu * 12.40;
            double priceVegMenu = numberVegMenu * 8.15;

            double all = priceChickenMenu + priceFishMenu + priceVegMenu;
            double dessert = (all * 0.2);
            double allFood = all + dessert+2.50;
            Console.WriteLine(allFood);
        }
    }
}
