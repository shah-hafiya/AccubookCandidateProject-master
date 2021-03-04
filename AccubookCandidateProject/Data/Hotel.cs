using System.Collections.Generic;

namespace AccubookCandidateProject.Data
{
    public class Hotel
    {
        public Hotel()
        {
            Bookings = new List<Booking>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}