using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResistenciaBR.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}