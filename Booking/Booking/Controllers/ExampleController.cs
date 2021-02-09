using Booking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Booking.Controllers
{
    public class ExampleController : Controller
    {
        public ActionResult Index()
        {
            ExampleRequest model = new ExampleRequest();
            model.AdultCount = 3;
            model.ChildCount = 1;
            model.Contact = "954879548";
            model.Name = "David";
            model.SpecialInsturctions = "Please sit next to fire place for special event.";
            model.ReservationTime = DateTime.Now;
            return View(model);
        }
    }
}
