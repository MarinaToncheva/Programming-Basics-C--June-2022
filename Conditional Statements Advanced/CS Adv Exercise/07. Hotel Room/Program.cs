using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberNights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApartment = 0;
            if (month == "May" || month == "October")
            {
                double studioPerNight = 50.0;
                double apartmentPerNight = 65.0;
                if (numberNights > 7 && numberNights <= 14)
                {
                   priceStudio = (studioPerNight - (studioPerNight * 0.05)) * numberNights;
                   priceApartment = numberNights * apartmentPerNight;
                }
                else if (numberNights > 14)
                {
                    priceStudio = (studioPerNight - (studioPerNight * 0.30)) * numberNights;
                    priceApartment = (apartmentPerNight - (apartmentPerNight * 0.10)) * numberNights;
                }
                else if (numberNights <= 7)
                {
                    priceStudio = numberNights * studioPerNight;
                    priceApartment = numberNights * apartmentPerNight;
                }
            }
            else if (month == "June" || month == "September")
            {
                double studioPerNight = 75.20;
                double apartmentPerNight = 68.70;

                if (numberNights <= 14)
                {
                  priceStudio = studioPerNight * numberNights;
                  priceApartment = numberNights * apartmentPerNight;
                }
                else if (numberNights > 14)
                {
                   priceStudio = (studioPerNight - (studioPerNight * 0.20)) * numberNights;
                   priceApartment = (apartmentPerNight - (apartmentPerNight * 0.10)) * numberNights;
                }
            }
            else if (month == "July" || month == "August")
            {
                double studioPerNight = 76.0;
                double apartmentPerNight = 77.0;

                if (numberNights <= 14)
                {
                    priceStudio = studioPerNight * numberNights;
                    priceApartment = numberNights * apartmentPerNight;
                }
                else if (numberNights > 14)
                {
                    priceStudio = studioPerNight * numberNights;
                    priceApartment = (apartmentPerNight - (apartmentPerNight * 0.10)) * numberNights;
                }

            }
            Console.WriteLine($"Apartment: {(priceApartment):f2} lv.");
            Console.WriteLine($"Studio: {(priceStudio):f2} lv.");
        }
    }
}
