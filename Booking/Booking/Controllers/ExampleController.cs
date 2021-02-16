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

        public ExampleRequest exampleOne;
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

        public ActionResult Establish() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Establish(ExampleRequest model) 
        {
            return RedirectToAction("Details");
        }

        public ActionResult Details(ExampleRequest model)
        {
            return View(this.exampleOne);
        }


        public ActionResult Upcoming()
        {
            var example = new ExampleRequest();
            var reservations = example.GetCurrentReservations();
            return View(reservations);
        }

        public ActionResult Edit(string name) 
        {
            ExampleRequest model = new ExampleRequest();
            var found = model.GetCurrentReservations().Where(x => x.Name == name).FirstOrDefault();
            return View(found);
        }

    }
}
