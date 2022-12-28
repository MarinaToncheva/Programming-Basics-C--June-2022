using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int numStudents = int.Parse(Console.ReadLine());
            int numNights = int.Parse(Console.ReadLine());
            double price = 0;
            switch (season)
            {
                case "Winter":
                    if (groupType=="girls")
                    {
                        if (numStudents<10)
                        {
                            price = numStudents * numNights*9.60;
                        }
                        else if (numStudents>=10 && numStudents<20)
                        {
                            price = (numStudents * numNights*9.60)-((numStudents * numNights*9.60)*0.05);
                        }
                        else if (numStudents>=20 && numStudents<50)
                        {
                            price = (numStudents * numNights*9.60) - ((numStudents * numNights*9.60) * 0.15);
                        }
                        else if (numStudents>=50)
                        {
                            price = (numStudents * numNights*9.60) - ((numStudents * numNights*9.60) * 0.50);
                        }
                        Console.WriteLine($"Gymnastics {price:f2} lv.");
                    }
                    else if (groupType=="boys")
                    {
                        if (numStudents < 10)
                        {
                            price = numStudents * numNights*9.60;
                        }
                        else if (numStudents >= 10 && numStudents < 20)
                        {
                            price = (numStudents * numNights*9.60) - ((numStudents * numNights*9.60) * 0.05);
                        }
                        else if (numStudents >= 20 && numStudents < 50)
                        {
                            price = (numStudents * numNights*9.60) - ((numStudents * numNights*9.60) * 0.15);
                        }
                        else if (numStudents >= 50)
                        {
                            price = (numStudents * numNights*9.60) - ((numStudents * numNights*9.60) * 0.50);     
                        }
                        Console.WriteLine($"Judo {price:f2} lv.");
                    }
                    else if (groupType=="mixed")
                    {
                        if (numStudents < 10)
                        {
                            price = numStudents * numNights * 10.0;
                        }
                        else if (numStudents >= 10 && numStudents < 20)
                        {
                            price = (numStudents * numNights * 10.0) - ((numStudents * numNights * 10.0) * 0.05);
                        }
                        else if (numStudents >= 20 && numStudents < 50)
                        {
                            price = (numStudents * numNights * 10.0) - ((numStudents * numNights * 10.0) * 0.15);
                        }
                        else if (numStudents >= 50)
                        {
                            price = (numStudents * numNights * 10.0) - ((numStudents * numNights * 10.0) * 0.50);
                        }
                        Console.WriteLine($"Ski {price:f2} lv.");
                    }
                break;
                case "Spring":
                    if (groupType == "girls")
                    {
                        if (numStudents < 10)
                        {
                            price = numStudents * numNights * 7.20;
                        }
                        else if (numStudents >= 10 && numStudents < 20)
                        {
                            price = (numStudents * numNights * 7.20) - ((numStudents * numNights * 7.20) * 0.05);
                        }
                        else if (numStudents >= 20 && numStudents < 50)
                        {
                            price = (numStudents * numNights * 7.20) - ((numStudents * numNights * 7.20) * 0.15);
                        }
                        else if (numStudents >= 50)
                        {
                            price = (numStudents * numNights * 7.20) - ((numStudents * numNights * 7.20) * 0.50);
                        }
                        Console.WriteLine($"Athletics {price:f2} lv.");
                    }
                    else if (groupType == "boys")
                    {
                        if (numStudents < 10)
                        {
                            price = numStudents * numNights * 7.20;
                        }
                        else if (numStudents >= 10 && numStudents < 20)
                        {
                            price = (numStudents * numNights * 7.20) - ((numStudents * numNights * 7.20) * 0.05);
                        }
                        else if (numStudents >= 20 && numStudents < 50)
                        {
                            price = (numStudents * numNights * 7.20) - ((numStudents * numNights * 7.20) * 0.15);
                        }
                        else if (numStudents >= 50)
                        {
                            price = (numStudents * numNights * 7.20) - ((numStudents * numNights * 7.20) * 0.50);
                        }
                        Console.WriteLine($"Tennis {price:f2} lv.");
                    }
                    else if (groupType == "mixed")
                    {
                        if (numStudents < 10)
                        {
                            price = numStudents * numNights * 9.50;
                        }
                        else if (numStudents >= 10 && numStudents < 20)
                        {
                            price = (numStudents * numNights * 9.50) - ((numStudents * numNights * 9.50) * 0.05);
                        }
                        else if (numStudents >= 20 && numStudents < 50)
                        {
                            price = (numStudents * numNights * 9.50) - ((numStudents * numNights * 9.50) * 0.15);
                        }
                        else if (numStudents >= 50)
                        {
                            price = (numStudents * numNights * 9.50) - ((numStudents * numNights * 9.50) * 0.50);
                        }
                        Console.WriteLine($"Cycling {price:f2} lv.");
                    }
                    break;
                default: 
                    if (groupType == "girls")
                    {
                        if (numStudents < 10)
                        {
                            price = numStudents * numNights * 15.0;
                        }
                        else if (numStudents >= 10 && numStudents < 20)
                        {
                            price = (numStudents * numNights * 15.0) - ((numStudents * numNights * 15.0) * 0.05);
                        }
                        else if (numStudents >= 20 && numStudents < 50)
                        {
                            price = (numStudents * numNights * 15.0) - ((numStudents * numNights * 15.0) * 0.15);
                        }
                        else if (numStudents >= 50)
                        {
                            price = (numStudents * numNights * 15.0) - ((numStudents * numNights * 15.0) * 0.50);
                        }
                        Console.WriteLine($"Volleyball {price:f2} lv.");
                    }
                    else if (groupType == "boys")
                    {
                        if (numStudents < 10)
                        {
                            price = numStudents * numNights * 15.0;
                        }
                        else if (numStudents >= 10 && numStudents < 20)
                        {
                            price = (numStudents * numNights * 15.0) - ((numStudents * numNights * 15.0) * 0.05);
                        }
                        else if (numStudents >= 20 && numStudents < 50)
                        {
                            price = (numStudents * numNights * 15.0) - ((numStudents * numNights * 15.0) * 0.15);
                        }
                        else if (numStudents >= 50)
                        {
                            price = (numStudents * numNights * 15.0) - ((numStudents * numNights * 15.0) * 0.50);
                        }
                        Console.WriteLine($"Football {price:f2} lv.");
                    }
                    else if (groupType == "mixed")
                    {
                        if (numStudents < 10)
                        {
                            price = numStudents * numNights * 20.0;
                        }
                        else if (numStudents >= 10 && numStudents < 20)
                        {
                            price = (numStudents * numNights * 20.0) - ((numStudents * numNights * 20.0) * 0.05);
                        }
                        else if (numStudents >= 20 && numStudents < 50)
                        {
                            price = (numStudents * numNights * 20.0) - ((numStudents * numNights * 20.0) * 0.15);
                        }
                        else if (numStudents >= 50)
                        {
                            price = (numStudents * numNights * 20.0) - ((numStudents * numNights * 20.0) * 0.50);
                        }
                        Console.WriteLine($"Swimming {price:f2} lv.");
                    }
                    break;
            }
        }
    }
}
