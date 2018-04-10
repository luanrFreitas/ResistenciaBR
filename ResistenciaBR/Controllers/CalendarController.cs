using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResistenciaBR.Controllers
{
    public class CalendarController : Controller
    {
        // GET: Calendar
        public ActionResult Index()
        {
            return View("Apr");
        }

        public ActionResult Sep()
        {
            return View();
        }

        public ActionResult Oct()
        {
            return View();
        }

        public ActionResult Nov()
        {
            return View();
        }

        public ActionResult Dez()
        {
            return View();
        }

        public ActionResult Jan()
        {
            return View();
        }

        public ActionResult Feb()
        {
            return View();
        }

        public ActionResult Mar()
        {
            return View();
        }

        public ActionResult Apr()
        {
            return View();
        }
    }
}