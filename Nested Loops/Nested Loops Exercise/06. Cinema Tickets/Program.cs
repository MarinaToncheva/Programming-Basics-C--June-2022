using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string film =string.Empty;
            int freeSeats = 0;

            double allTickets = 0;
            double countTickets = 0;
            double countStandard = 0;
            double countKid = 0;
            double countStudent = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Finish")
                {
                    break;
                }
                else
                {
                    film = input;
                    freeSeats = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= freeSeats; i++)
                    {
                        string type = Console.ReadLine();
                        if (type=="End")
                        {
                            Console.WriteLine($"{film} - {((countTickets / freeSeats) * 100):f2}% full.");
                            countTickets = 0;
                            break;
                        }
                        else
                        {
                            countTickets++;
                            allTickets++;
                            if (type == "standard")
                            {
                                countStandard++;
                            }
                            else if (type == "student")
                            {
                                countStudent++;
                            }
                            else if (type == "kid")
                            {
                                countKid++;
                            }
                            if (i == freeSeats)
                            {
                                Console.WriteLine($"{film} - {((countTickets / freeSeats) * 100):f2}% full.");
                                countTickets = 0;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{((countStudent / allTickets) * 100):f2}% student tickets.");
            Console.WriteLine($"{((countStandard / allTickets) * 100):f2}% standard tickets.");
            Console.WriteLine($"{((countKid / allTickets) * 100):f2}% kids tickets.");
        }
    }
}
