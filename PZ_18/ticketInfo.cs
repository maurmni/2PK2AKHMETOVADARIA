using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PZ_18.ticketInfo;

namespace PZ_18
{
    internal class ticketInfo
    {
        public enum ticketCategory { Economy, Business }

        public class AirplaneTicket
        {
            public ticketCategory Category { get; set; }
            private string seatNumber;
            private string passengerName;
            public string SeatNumber
            {
                get { return seatNumber; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        seatNumber = value;
                    }
                    else
                    {
                        Console.WriteLine("Введите номер места.");
                    }
                }
            }
            public string PassengerName
            {
                get { return passengerName; }
                set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        passengerName = value;
                    }
                    else
                    {
                        Console.WriteLine("Введите ФИО пассажира.");
                    }
                }
            }

            public DateTime DateOfBirth { get; set; }
            public DateTime DepartureTime { get; set; }

            public decimal TicketPrice
            {
                get
                {
                    decimal price = (Category == ticketCategory.Business) ? 10000 : 7000;
                    if ((DateTime.Today - DateOfBirth).TotalDays / 365 < 10)
                    {
                        price /= 2; 
                    }
                    return price;
                }
            }

            public static int EconomyTicketsSold { get; set; }
            public static int BusinessTicketsSold { get; set; }

            public static void DisplaySoldTicketsCount()
            {
                Console.WriteLine($"Продано билетов в эконом классе: {EconomyTicketsSold}");
                Console.WriteLine($"Продано билетов в бизнес классе: {BusinessTicketsSold}");
            }

            public void DisplayTicketInfo()
            {
                Console.WriteLine($"Номер места: {SeatNumber}");
                Console.WriteLine($"Дата/время вылета: {DepartureTime}");
                Console.WriteLine($"ФИО пассажира: {PassengerName}");
                Console.WriteLine($"Категория билета: {Category}");
            }

            public void DisplayRemainingTimeUntilDeparture()
            {
                TimeSpan remainingTime = DepartureTime - DateTime.Now;
                Console.WriteLine($"Оставшееся время до вылета: {remainingTime.Days} дней, {remainingTime.Hours} часов, {remainingTime.Minutes} минут");
            }
        }
    }
}
