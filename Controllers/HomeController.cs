using System.Web.Mvc;
using Ebs.Interfaces;

namespace Ebs.Controllers
{
    public class HomeController : Controller
    {
        #region Constructor
        private readonly IRepository _repo;
        public HomeController(IRepository repo) => this._repo = repo;
        #endregion

        #region Public Methods
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
        #endregion
    }
}