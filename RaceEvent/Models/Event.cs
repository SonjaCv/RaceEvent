using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaceEvent.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public DateTime DisplayDate { get; set; }
        public string City { get; set; }
        public string Activity { get; set; }

        public string BackgroundPhotoUrl { get; set; }
        public string SponsorPhotoUrl { get; set; }
        public string aAppLogoPhotoUrl { get; set; }
    }
}