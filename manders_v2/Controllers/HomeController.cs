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
            ViewBag.Message = "Элитные обои, изысканый текстиль, английские краски, качество в Украине";

            return View();
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Компания MANDERS – эксклюзивный поставщик английских декоративных материалов";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Связаться с нами";

            return View();
        }
        public ActionResult Advice()
        {
            ViewBag.Message = "Рекомендации для получения наилучшего результата.";
            return View();
        }
        public ActionResult News()
        {
            ViewBag.Message = "Новости обои, текстиля, красок на нашем сайте в Украине и за ее пределами";
            return View();
        }
       public ActionResult Video()
        {
            ViewBag.Message = "Видео материалы характеризующие то чем мы занимаемся";
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Галерея фотографий";
            return View();
        }
        
        public ActionResult Manuals()
        {
            ViewBag.Message = "Каталоги, документация, вырезки ...";
            return View();
        }
       
    }
}
