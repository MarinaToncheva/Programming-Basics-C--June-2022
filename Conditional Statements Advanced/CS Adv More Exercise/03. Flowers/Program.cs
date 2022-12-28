using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numChrysanthemum = int.Parse(Console.ReadLine());
            int numRoses = int.Parse(Console.ReadLine());
            int numTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayOrNot = Console.ReadLine();

            int amountFlowers = numTulips + numRoses + numChrysanthemum;

            double price = 0;
            double priceOnHoliday = 0;
            double endPrice = 0;
            double finalDiscount = 0;
            double discountTulips = 0;
            double discountRoses = 0;
            switch (season)
            {
                case "Spring":

                    price = numChrysanthemum * 2.0 + numRoses * 4.10 + numTulips * 2.50;
                    if (holidayOrNot == "Y")
                    {
                        priceOnHoliday = price + (price * 0.15);
                        if (numTulips <= 7)
                        {
                            if (amountFlowers <= 20)
                            {
                                endPrice = priceOnHoliday + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                            else if (amountFlowers > 20)
                            {
                                finalDiscount = priceOnHoliday - (priceOnHoliday * 0.20);
                                endPrice = finalDiscount + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                        }
                        else if (numTulips > 7)
                        {
                            if (amountFlowers <= 20)
                            {
                                discountTulips = priceOnHoliday - (priceOnHoliday * 0.05);
                                endPrice = discountTulips + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                            else if (amountFlowers > 20)
                            {
                                discountTulips = priceOnHoliday - (priceOnHoliday * 0.05);
                                endPrice = discountTulips - (discountTulips * 0.20) + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                        }
                    }
                    else if (holidayOrNot == "N")
                    {
                        priceOnHoliday = price;
                        if (numTulips <= 7)
                        {
                            if (amountFlowers <= 20)
                            {
                                endPrice = priceOnHoliday + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                            else if (amountFlowers > 20)
                            {
                                finalDiscount = priceOnHoliday - (priceOnHoliday * 0.20);
                                endPrice = finalDiscount + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                        }
                        else if (numTulips > 7)
                        {
                            if (amountFlowers <= 20)
                            {
                                discountTulips = priceOnHoliday - (priceOnHoliday * 0.05);
                                endPrice = discountTulips + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                            else if (amountFlowers > 20)
                            {
                                discountTulips = priceOnHoliday - (priceOnHoliday * 0.05);
                                endPrice = discountTulips - (discountTulips * 0.20) + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                        }
                    }
                    break;
                case "Summer":
                    price = numChrysanthemum * 2.0 + numRoses * 4.10 + numTulips * 2.50;
                    if (holidayOrNot == "Y")
                    {
                        priceOnHoliday = price + (price * 0.15);
                        if (amountFlowers <= 20)
                        {
                            endPrice = priceOnHoliday + 2.0;
                            Console.WriteLine($"{endPrice:f2}");
                        }
                        else if (amountFlowers > 20)
                        {
                            finalDiscount = priceOnHoliday - (priceOnHoliday * 0.20);
                            endPrice = finalDiscount + 2.0;
                            Console.WriteLine($"{endPrice:f2}");
                        }
                    }
                    else if (holidayOrNot == "N")
                    {
                        priceOnHoliday = price;

                        if (amountFlowers <= 20)
                        {
                            endPrice = priceOnHoliday + 2.0;
                            Console.WriteLine($"{endPrice:f2}");
                        }
                        else if (amountFlowers > 20)
                        {
                            finalDiscount = priceOnHoliday - (priceOnHoliday * 0.20);
                            endPrice = finalDiscount + 2.0;
                            Console.WriteLine($"{endPrice:f2}");
                        }
                    }
                    break;
                case "Autumn":
                    price = numChrysanthemum * 3.75 + numRoses * 4.50 + numTulips * 4.15;
                    if (holidayOrNot == "Y")
                    {
                        priceOnHoliday = price + (price * 0.15);
                        if (amountFlowers <= 20)
                        {
                            endPrice = priceOnHoliday + 2.0;
                            Console.WriteLine($"{endPrice:f2}");
                        }
                        else if (amountFlowers > 20)
                        {
                            finalDiscount = priceOnHoliday - (priceOnHoliday * 0.20);
                            endPrice = finalDiscount + 2.0;
                            Console.WriteLine($"{endPrice:f2}");
                        }
                    }
                    else if (holidayOrNot == "N")
                    {
                        priceOnHoliday = price;

                        if (amountFlowers <= 20)
                        {
                            endPrice = priceOnHoliday + 2.0;
                            Console.WriteLine($"{endPrice:f2}");

                        }
                        else if (amountFlowers > 20)
                        {
                            finalDiscount = priceOnHoliday - (priceOnHoliday * 0.20);
                            endPrice = finalDiscount + 2.0;
                            Console.WriteLine($"{endPrice:f2}");
                        }
                    }
                    break;
                default:
                    price = numChrysanthemum * 3.75 + numRoses * 4.50 + numTulips * 4.15;
                    if (holidayOrNot == "Y")
                    {
                        priceOnHoliday = price + (price * 0.15);
                        if (numRoses < 10)
                        {
                            if (amountFlowers <= 20)
                            {
                                endPrice = priceOnHoliday + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                            else if (amountFlowers > 20)
                            {
                                finalDiscount = priceOnHoliday - (priceOnHoliday * 0.20);
                                endPrice = finalDiscount + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                        }
                        else if (numRoses >= 10)
                        {

                            if (amountFlowers <= 20)
                            {
                                discountRoses = priceOnHoliday - (priceOnHoliday * 0.10);
                                endPrice = discountRoses + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                            else if (amountFlowers > 20)
                            {
                                discountRoses = priceOnHoliday - (priceOnHoliday * 0.10);
                                endPrice = discountRoses - (discountRoses * 0.20) + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                        }
                    }
                    else if (holidayOrNot == "N")
                    {
                        priceOnHoliday = price;
                        if (numRoses < 10)
                        {
                            if (amountFlowers <= 20)
                            {
                                endPrice = priceOnHoliday + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                            else if (amountFlowers > 20)
                            {
                                finalDiscount = priceOnHoliday - (priceOnHoliday * 0.20);
                                endPrice = finalDiscount + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                        }
                        else if (numRoses >= 10)
                        {
                            if (amountFlowers <= 20)
                            {
                                discountRoses = priceOnHoliday - (priceOnHoliday * 0.10);
                                endPrice = discountRoses + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                            else if (amountFlowers > 20)
                            {
                                discountRoses = priceOnHoliday - (priceOnHoliday * 0.10);
                                endPrice = discountRoses - (discountRoses * 0.20) + 2.0;
                                Console.WriteLine($"{endPrice:f2}");
                            }
                        }
                    }
               break;
            }
        }
    }
}
