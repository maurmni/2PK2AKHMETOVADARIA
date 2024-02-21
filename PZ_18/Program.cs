using static PZ_18.ticketInfo;

namespace PZ_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirplaneTicket ticket = new AirplaneTicket();

            ticket.SeatNumber = "A58";
            ticket.DepartureTime = DateTime.Now.AddHours(24);
            ticket.PassengerName = "Павел Павлов";
            ticket.Category = ticketCategory.Economy; 

            Console.WriteLine("Информация о билете:");
            Console.WriteLine($"Номер места: {ticket.SeatNumber}");
            Console.WriteLine($"Дата/время вылета: {ticket.DepartureTime}");
            Console.WriteLine($"ФИО пассажира: {ticket.PassengerName}");
            Console.WriteLine($"Категория билета: {ticket.Category}");

            ticket.DisplayRemainingTimeUntilDeparture();
        }

    }
}