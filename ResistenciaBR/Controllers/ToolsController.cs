using ResistenciaBR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ResistenciaBR.Controllers
{
    public class ToolsController : Controller
    {
        // GET: Tools
        [Authorize]
        public ActionResult Index()
        {
            if (Session["ListaHerois"] != null)
            {
                return View();
            }
            else
                return RedirectToAction("Identify");
        }

        [Authorize]
        public ActionResult Identify()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Identify(string SwgohProfile)
        {
            string texto = "<div class=\"col-xs-6 col-sm-3 col-md-3 col-lg-2\"(?<Tudo>.*?)<\\/a><\\/div>\n<\\/div>\n<\\/div>";
            string texto2 = "alt=\"(?<Nome>.*)\" height=.*<div class=\"star star(?<Raridade>.*[^star\\-inactive])\"><\\/div>.*full-level\">(?<Nivel>.+)<\\/div>.*gear-level\">(?<Equipamento>.+)<\\/div>\n<\\/a.*Power (?<Poder>.*?)\">.*style=\"width: (?<Progresso>.+);\"><\\/div>";

            WebClient client = new WebClient();
            String fonte = client.DownloadString("https://swgoh.gg/u/" + SwgohProfile + "/collection/");

            Regex rgx = new Regex(texto, RegexOptions.Singleline);

            var match = rgx.Matches(fonte);

            List<Heroi> Herois = new List<Heroi>();

            foreach (Match item in match)
            {

                Regex rgx2 = new Regex(texto2, RegexOptions.Singleline);

                var match2 = rgx2.Matches(item.Value);
                foreach (Match item2 in match2)
                {
                    Herois.Add(new Heroi
                    {
                        Nome = item2.Groups["Nome"].Value.Replace("&quot;", ""),
                        Raridade = Int32.Parse(item2.Groups["Raridade"].Value),
                        Nivel = Int32.Parse(item2.Groups["Nivel"].Value),
                        Equipamento = item2.Groups["Equipamento"].Value,
                        Poder = item2.Groups["Poder"].Value,
                        Progresso = item2.Groups["Progresso"].Value

                    });
                }
            }

            Session["ListaHerois"] = Herois;
            return View("Index",Herois);
        }
        [Authorize]
        public ActionResult EventGuide()
        {
            if (Session["ListaHerois"] != null)
            {
                List<Heroi> Herois = (List<Heroi>)Session["ListaHerois"];
                return View(Herois);
            }
            else
                return RedirectToAction("Identify");
        }

        public ActionResult RaidGuide()
        {
            if (Session["ListaHerois"] != null)
            {
                List<Heroi> Herois = (List<Heroi>)Session["ListaHerois"];
                return View(Herois);
            }
            else
                return RedirectToAction("Identify");
        }
        [Authorize]
        public ActionResult ListHeroes()
        {
            if (Session["ListaHerois"] != null)
            {
                List<Heroi> Herois = (List<Heroi>)Session["ListaHerois"];
                return View(Herois);
            } else
                return RedirectToAction("Identify");
        }
    }
}