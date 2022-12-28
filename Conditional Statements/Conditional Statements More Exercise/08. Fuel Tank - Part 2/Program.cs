using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double quantityFuel = double.Parse(Console.ReadLine());
            string possessionCard = Console.ReadLine();
            double price = 0;
            double finalPrice = 0;

            if (fuel == "Gas")
            {
                if (quantityFuel<20)
                {
                    if (possessionCard == "Yes")
                    {
                        price = quantityFuel * (0.93 - 0.08);
                    }
                    else
                    {
                        price = quantityFuel * 0.93;
                    }
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (quantityFuel==20 || quantityFuel <= 25)
                {
                    if (possessionCard == "Yes")
                    {
                        price = quantityFuel * (0.93 - 0.08);
                        finalPrice = price - (price * 0.08);
                    }
                    else
                    {
                        price = quantityFuel * 0.93;
                        finalPrice = price - (price * 0.08);
                    }
                    Console.WriteLine($"{finalPrice:f2} lv.");
                }
                else if (quantityFuel>25)
                {
                    if (possessionCard == "Yes")
                    {
                        price = quantityFuel * (0.93 - 0.08);
                        finalPrice = price - (price * 0.10);
                    }
                    else
                    {
                        price = quantityFuel * 0.93;
                        finalPrice = price - (price * 0.10);
                    }
                    Console.WriteLine($"{finalPrice:f2} lv.");
                }
             }
            else if (fuel=="Gasoline")
            {
                if (quantityFuel < 20)
                {
                    if (possessionCard == "Yes")
                    {
                        price = quantityFuel * (2.22 - 0.18);
                    }
                    else
                    {
                        price = quantityFuel * 2.22;
                    }
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (quantityFuel == 20 || quantityFuel <= 25)
                {
                    if (possessionCard == "Yes")
                    {
                        price = quantityFuel * (2.22 - 0.18);
                        finalPrice = price - (price * 0.08);
                    }
                    else
                    {
                        price = quantityFuel * 2.22;
                        finalPrice = price - (price * 0.08);
                    }
                    Console.WriteLine($"{finalPrice:f2} lv.");
                }
                else if (quantityFuel > 25)
                {
                    if (possessionCard == "Yes")
                    {
                       price = quantityFuel * (2.22 - 0.18);
                       finalPrice = price - (price * 0.10);
                    }
                    else
                    {
                        price = quantityFuel * 2.22;
                        finalPrice = price - (price * 0.10);
                    }
                    Console.WriteLine($"{finalPrice:f2} lv.");
                }
            }
            else if (fuel =="Diesel")
            {
                if (quantityFuel < 20)
                {
                    if (possessionCard == "Yes")
                    {
                        price = quantityFuel * (2.33 - 0.12);
                    }
                    else
                    {
                        price = quantityFuel * 2.33;
                    }
                    Console.WriteLine($"{price:f2} lv.");
                }
                else if (quantityFuel == 20 || quantityFuel <= 25)
                {
                    if (possessionCard == "Yes")
                    {
                        price = quantityFuel * (2.33 - 0.12);
                        finalPrice = price - (price * 0.08);
                    }
                    else
                    {
                        price = quantityFuel * 2.33;
                        finalPrice = price - (price * 0.08);
                    }
                    Console.WriteLine($"{finalPrice:f2} lv.");
                }
                else if (quantityFuel > 25)
                {
                    if (possessionCard == "Yes")
                    {
                        price = quantityFuel * (2.33 - 0.12);
                        finalPrice = price - (price * 0.10);
                    }
                    else
                    {
                        price = quantityFuel * 2.33;
                        finalPrice = price - (price * 0.10);
                    }
                    Console.WriteLine($"{finalPrice:f2} lv.");
                }
            }
        }
    }
}