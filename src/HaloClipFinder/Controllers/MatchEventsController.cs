using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HaloClipFinder.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HaloClipFinder.Controllers
{
    public class MatchEventsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetMatchEvents(string GamerTag)
        {
            List<MatchEvents.GameEvent> relevantEventsList = MatchEvents.GetMatchEvents(GamerTag);
            if (relevantEventsList.Count > 0)
            {
                List<Medal.Root> allMedals = new List<Medal.Root> { };
                for (int i = 0; i < relevantEventsList.Count; i++)
                {
                    allMedals.Add(Medal.GetMedal(relevantEventsList[i].MedalId));
                }
                ViewBag.MatchEvents = relevantEventsList;
                ViewBag.MatchMedals = allMedals;

                return View();
            }
            else
            {
                return RedirectToAction("NoMedals");
            }
        }

        public IActionResult NoMedals()
        {
            return View();
        }
    }
}
