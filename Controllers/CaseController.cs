using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    public class CaseController : Controller
    {
        // GET: CaseController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CaseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CaseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CaseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AllCase()
        {
            return View();
        }
    }
}
