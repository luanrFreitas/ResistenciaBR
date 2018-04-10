using ResistenciaBR.Models;
using ResistenciaBR.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResistenciaBR.Controllers
{
    public class TipController : Controller
    {
        [Authorize]
        // GET: Tip
        public ActionResult Index()
        {
            TipService tip = new TipService();
            return View(tip.Listar());
        }

        // GET: Tip/Details/5
        public ActionResult Details(int id)
        {
            TipService srv = new TipService();
            return View(srv.Obter(id));
          
        }

        // GET: Tip/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tip/Create
        [HttpPost]
        public ActionResult Create(Tip model)
        {
            if (ModelState.IsValid)
            {
                model.Autor= User.Identity.Name;
                TipService srv = new TipService();
                srv.Salvar(model);
                return View("Index", srv.Listar());
            }
            else
                return View(model);



        }

        // GET: Tip/Edit/5
        public ActionResult Edit(int id)
        {
            TipService tipSrv = new TipService();
            Tip tip = tipSrv.Obter(id);
            return View("Create",tip);
        }

        // POST: Tip/Edit/5
        [HttpPost]
        public ActionResult Edit(Tip model)
        {
            if(ModelState.IsValid)
            {
                TipService tipSrv = new TipService();
                tipSrv.Salvar(model);
                return View("List",tipSrv.Listar());
            }
            else
            {
                return View("Create",model);
            }
        }

        // GET: Tip/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tip/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult swgohgg()
        {
            return View("Custom/swgohgg");
        }
    }
}
