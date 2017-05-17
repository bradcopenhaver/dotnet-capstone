using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HaloClipFinder.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HaloClipFinder.Controllers
{
    public class MatchResultsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetCurrentMatch(string MatchId, string GameMode)
        {
            MatchResults.GetMatchResultsById(MatchId, GameMode);
            MatchEvents.GetMatchEventsById(MatchId);
            ViewBag.CurrentTeams = MatchResults.CurrentTeams;
            return View();
        }
    }
}