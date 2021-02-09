using Booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Booking.Controllers
{
    public class BookingController : ApiController
    {
        [Route("api/booking/connection")]
        [HttpGet]
        public string Connection() 
        {
            return "status ok.";
        }

        [Route("api/book/exampleReservation")]
        [HttpGet]
        public ExampleRequest ExampleReservation() 
        {
            ExampleRequest model = new ExampleRequest();
            model.AdultCount = 3;
            model.ChildCount = 1;
            model.Contact = "954879548";
            model.Name = "David";
            model.SpecialInsturctions = "Please sit next to fire place for special event.";
            model.ReservationTime = DateTime.Now;
            return model;
        }

    }
}
