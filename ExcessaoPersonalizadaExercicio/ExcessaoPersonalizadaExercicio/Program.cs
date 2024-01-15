using ExcessaoPersonalizadaExercicio.Entities;

namespace ExcessaoPersonalizadaExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkout <= checkin)
            {
                Console.WriteLine("Error in reservation: Check-out data must be after check-in date.");
            }
            else
            {
                Reservation reservation = new Reservation(roomNumber, checkin, checkout);
                Console.WriteLine(reservation);
            }

            Console.WriteLine("Enter data to update the reservation:");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkout = DateTime.Parse(Console.ReadLine());

            if (checkin <= DateTime.Now || checkout <= DateTime.Now)
            {
                Console.WriteLine("Error in reservation: Reservation dates for update must be furture dates.");
            }
            
            if (checkout <= checkin)
            {
                Console.WriteLine("Error in reservation: Check-out data must be after check-in date.");
            }
            else
            {
                reservation.Update()
            }

        }
    }
}