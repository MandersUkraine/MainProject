using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace manders_v2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Элитные обои, мебель, элитный текстиль, английские краски в Украине";

            return View();
        }
        public ActionResult Other()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Компания MANDERS – эксклюзивный поставщик английских декоративных материалов";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Advice()
        {
            return View();
        }
        public ActionResult Manuals()
        {
            return View();
        }
        public ActionResult Video()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Галерея фотографий";
            return View();
        }
    }
}
