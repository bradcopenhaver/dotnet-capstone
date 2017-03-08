using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HaloClipFinder.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HaloClipFinder.Controllers
{
    public class PlayerMatchHistoryController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetPlayerHistory(string gamertag, string modes)
        {
            PlayerMatchHistory.Root matchHistory = PlayerMatchHistory.GetPlayerMatchHistory(gamertag, modes);

            if (int.Parse(matchHistory.ResultCount) <1)
            {
                RedirectToAction("NoResults");
            }
            ViewBag.MatchHistory = matchHistory;
            return View();
        }

        public IActionResult NoResults()
        {
            return View();
        }
    }
}
