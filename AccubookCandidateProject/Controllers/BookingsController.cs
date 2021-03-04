using AccubookCandidateProject.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace AccubookCandidateProject.Controllers
{
    public class BookingsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }

    public class BookingsApiController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/bookings")]
        public async Task<IHttpActionResult> GetBookings()
        {

            List<Booking> bookinglist = new List<Booking>() { new Booking() { Id = 1, Name = "Test", HotelId = 1, Rate = 100, Arrival = DateTime.Now, Departure = DateTime.Now  } };
            // your code goes here

            return Ok(bookinglist);



        }




        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/booking")]
        public async Task<IHttpActionResult> PostBooking()
        {
            // your code goes here

            return Ok();
        }
    }
}