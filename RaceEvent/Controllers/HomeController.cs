using Newtonsoft.Json;
using RaceEvent.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaceEvent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Session["EventRace"] == null)
                LoadEventRace();

            EventRace eventRace = (EventRace)Session["EventRace"];
            return View(eventRace.Races.ToList());
        }

        public ActionResult Classification(int? raceId, string raceName)
        {
            ViewBag.RaceName = raceName;

            if (Session["Classifications"] == null)
                LoadClassifications();

            var _classifications = (List<Models.Classification>)Session["Classifications"];

            if (raceId != null)
                _classifications = (List<Classification>)_classifications.Where(s => s.RaceId == raceId).ToList();

            return View(_classifications);
        }

        /// <summary>
        /// Load Json Data
        /// </summary>
        /// <returns></returns>
        public void LoadEventRace()
        {
            string jsonFile = HttpContext.Server.MapPath("~/JSON/json_test_data.txt");
            using (StreamReader streamReader = new StreamReader(new FileStream(jsonFile, FileMode.Open)))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                Session["EventRace"] = (EventRace)jsonSerializer.Deserialize(streamReader, typeof(EventRace));
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void LoadClassifications()
        {
            EventRace eventRace = (EventRace)Session["EventRace"];
            List<Models.Classification> classifications = new List<Models.Classification>();

            foreach (Race race in eventRace.Races)
                classifications.AddRange(race.Classifications);

            Session["Classifications"] = classifications;
        }
    }
}