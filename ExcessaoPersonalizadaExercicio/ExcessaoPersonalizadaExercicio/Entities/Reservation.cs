using System;

namespace ExcessaoPersonalizadaExercicio.Entities
{
    class Reservation
    {
        public int RoomReservation { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public Reservation()
        {
        }
        public Reservation(int roomReservation, DateTime checkin, DateTime checkout)
        {
            RoomReservation = roomReservation;
            Checkin = checkin;
            Checkout = checkout;
        }
        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateReservation(DateTime checkin, DateTime checkout)
        {
            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Reservation: Room "
                + RoomReservation
                + " check-in: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", check-out: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
