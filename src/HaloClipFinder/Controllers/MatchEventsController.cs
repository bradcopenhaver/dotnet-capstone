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
        public IActionResult GetMatchEvents(string MatchId, string GamerTag)
        {
            ViewBag.MatchEvents = MatchEvents.GetMatchEvents(MatchId, GamerTag);

            return View();
        }
    }
}
