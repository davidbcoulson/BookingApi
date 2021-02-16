using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Booking.Models
{
    public class ExampleRequest
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public int AdultCount { get; set; }
        public int ChildCount { get; set; }
        public string SpecialInsturctions { get; set; }
        public DateTime ReservationTime { get; set; }
        public List<ExampleRequest> GetCurrentReservations()
        {

            List<ExampleRequest> finalResults = new List<ExampleRequest>();

            ExampleRequest one = new ExampleRequest()
            {
                Name = "David",
                Contact = "123456789",
                AdultCount = 5,
                ChildCount = 6,
                SpecialInsturctions = "water at table when guest arrive.",
                ReservationTime = DateTime.Now.AddHours(3)
            };
            finalResults.Add(one);

            ExampleRequest two = new ExampleRequest()
            {
                Name = "Denis",
                Contact = "789456123",
                AdultCount = 2,
                ChildCount = 3,
                SpecialInsturctions = "Glutten alergy.",
                ReservationTime = DateTime.Now.AddHours(3)
            };
            finalResults.Add(two);

            ExampleRequest three = new ExampleRequest()
            {
                Name = "Pat",
                Contact = "12345678",
                AdultCount = 3,
                ChildCount = 0,
                SpecialInsturctions = "",
                ReservationTime = DateTime.Now.AddHours(3)
            };
            finalResults.Add(three);
            return finalResults;
        }
    }
}