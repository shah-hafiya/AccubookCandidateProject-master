using System;

namespace AccubookCandidateProject.Models
{
    public class BookingDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public decimal Rate { get; set; }
        public int HotelId { get; set; }

        public string HotelName { get; set; }
    }

    public class HotelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        /// <summary>
        /// The total number of times the hotel was booked.
        /// </summary>
        public int TimesBooked { get; set; }

        /// <summary>
        /// The gross value taken in by the hotel for all of their bookings.
        /// </summary>
        public decimal TotalBookingsValue { get; set; }

        /// <summary>
        /// The average rate a guest pays based on all of the bookings.
        /// </summary>
        public decimal AverageBookingRate { get; set; }

        /// <summary>
        /// The average number of nights a guest stays.
        /// </summary>
        public int AverageNightsStayed { get; set; }
    }
}