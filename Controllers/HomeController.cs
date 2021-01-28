using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Interfaces;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository  _repo;

        public HomeController(IRepository repo)
        {
            this._repo = repo;
        }
        public ActionResult Index()
        {
            var p = _repo.ListPeople();
            return View(p);
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