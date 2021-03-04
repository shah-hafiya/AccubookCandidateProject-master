using AccubookCandidateProject.Data;
using AccubookCandidateProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace AccubookCandidateProject.Controllers
{
    public class HotelsController : Controller
    {
        public ActionResult Index()
        {
            HotelContext db = new HotelContext();
            List<HotelDTO> hotelDTOs = new List<HotelDTO>();

            foreach (Hotel h in db.Hotels)
            {
                HotelDTO dto = new HotelDTO
                {
                    Id = h.Id,
                    Name = h.Name,
                    Address = h.Address,
                    TimesBooked = db.Bookings.Where(b => b.HotelId == h.Id).Count(),
                    TotalBookingsValue = db.Bookings.Where(b => b.HotelId == h.Id).Sum(x => x.Rate)
                };
                hotelDTOs.Add(dto);
            };
            return View(hotelDTOs);


        }



        // your code here - optimize existing code & add any missing code
    }
    }
