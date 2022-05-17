using GameCollectionApp.Models.Games;
using GameCollectionApp.Orchestrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GameCollectionApp.Controllers
{
    public class HomeController : Controller
    {
        readonly IGetGameCollectionOrchestrator getGameCollectionOrchestrator;

        public HomeController(IGetGameCollectionOrchestrator getGameCollectionOrchestrator)
        {
            this.getGameCollectionOrchestrator = getGameCollectionOrchestrator;
        }

        public ActionResult Index()
        {
            Game games = new Game();
            games = getGameCollectionOrchestrator.GetGame();

            return View("Index", games);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}