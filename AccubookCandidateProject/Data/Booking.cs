using System;

namespace AccubookCandidateProject.Data
{
    public class Booking
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public decimal Rate { get; set; }
        public int HotelId { get; set; }

        public virtual Hotel Hotel { get; set; }
    }
}